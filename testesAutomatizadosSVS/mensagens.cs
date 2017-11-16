using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesAutomatizadosSVS
{
    class mensagens
    {
        
       public static void TestPostMessage(string texto)  
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";

            SlackClient client = new SlackClient(urlWithAccessToken);

            client.PostMessage(username: "Teste_Automatizado",
                       text: texto,
                       channel: "#teste_teste");   //depois atualizar para o github_feed
        }
    }
}
