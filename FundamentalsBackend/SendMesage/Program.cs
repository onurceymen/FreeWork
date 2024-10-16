using System.Net;
using System.Net.WebSockets;
using System.Text;

public class Program
{
	static List<WebSocket> clients = new List<WebSocket>();

	public static async Task Main(string[] args)
	{
		HttpListener listener = new HttpListener();
		listener.Prefixes.Add("http://localhost:5000/ws/");
		listener.Start();
		Console.WriteLine("WebSocket server is running on ws://localhost:5000/ws/");

		// Mesaj gönderme işlemini başka bir thread'de başlatıyoruz
		Task.Run(() => ReadAndBroadcastMessagesFromConsole());

		while (true) { 
		HttpListenerContext context = await listener.GetContextAsync();

			if (context.Request.IsWebSocketRequest)
			{
				HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(null);
				WebSocket webSocket = webSocketContext.WebSocket;

				Console.WriteLine("Client connected");
				clients.Add(webSocket);


				await ReceiveAndBroadcastMessages(webSocket);

			}
			else 
			{
				context.Response.StatusCode = 400;
				context.Response.Close();
			}


        }
	}

	public static async Task ReadAndBroadcastMessagesFromConsole()
	{
		while (true)
		{
			string consoleMessage = Console.ReadLine();

			await BroadcastMessage(consoleMessage);
		}
	}

	public static async Task ReceiveAndBroadcastMessages(WebSocket webSocket)
	{
		var buffer = new byte[1024 * 4];

		while (webSocket.State == WebSocketState.Open)
		{
			WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

			// Gelen mesajı alalım
			string receivedMessage = Encoding.UTF8.GetString(buffer, 0, result.Count);
			Console.WriteLine("Alınan mesaj: " + receivedMessage);

			// Mesajı diğer bağlı istemcilere yay
			await BroadcastMessage(receivedMessage);

			// Eğer bağlantı kapatılırsa, istemciyi listeden çıkaralım
			if (result.MessageType == WebSocketMessageType.Close)
			{
				clients.Remove(webSocket);
				await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by the server", CancellationToken.None);
				Console.WriteLine("Client disconnected.");
				break;
			}
		}
	}

	public static async Task BroadcastMessage(string message)
	{
		var messageBytes = Encoding.UTF8.GetBytes(message);

		foreach (var client in clients.ToList())
		{
			if (client.State == WebSocketState.Open)
			{
				await client.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);
			}
		}
	}



	public static async Task SendMessages(WebSocket webSocket)
	{
		var buffer = new byte[1024];
		while (webSocket.State == WebSocketState.Open)
		{
			//Gonderilecek Mesajı oluştur
			string message = "Serverden Anlık Mesaj :" + DateTime.Now.ToString();
			byte[] messageBytes = Encoding.UTF8.GetBytes(message);

			await webSocket.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);

			Console.WriteLine("Mesaj Gönderildi" + message);
			await Task.Delay(5000);
		}
	}



}