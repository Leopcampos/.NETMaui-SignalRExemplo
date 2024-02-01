using Microsoft.AspNetCore.SignalR;

namespace SignalRExemplo1.Hubs;

/// <summary>
/// Hub do SignalR
/// </summary>
public class ChatHub : Hub
{
    /// <summary>
    /// Método para que um componente envie uma mensagem
    /// </summary>
    public async Task SendMessage(string user, string message)
    {
        /*
        * Criando uma resposta para que os componente 'ouvintes'
        * possam escutar e receber a mensagem capturada pelo Hub
        * 'ReceiveMessage' => nome da função que o componente
        * deverá 'ouvir' para capturar o conteudo da mensagem
        */
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}