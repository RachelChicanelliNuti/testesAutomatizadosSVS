using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SlackWebhook;
using System;
using TechTalk.SpecFlow;

namespace testesAutomatizadosSVS.feature.steps
{
    [Binding]
    public class AutenticacaoNoSistemaSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"que estou na página de autenticacao")]

        public void DadoQueEstouNaPaginaDeAutenticacao()
        {
           
            driver.Navigate().GoToUrl("http://192.168.207.157/");
        }

        [When(@"eu preencho o campo CPF com o valor '(.*)'")]
        public void QuandoEuPreenchoOCampoCPFComOValor(string cpf)
        {
            IWebElement cpfTxt = driver.FindElement(By.Id("CPF"));
            cpfTxt.SendKeys(cpf);
        }

        [When(@"preencha o campo Senha com o valor '(.*)'")]
        public void QuandoPreenchaOCampoSenhaComOValor(string senha)
        {
            IWebElement senhaTxt = driver.FindElement(By.Id("Senha"));
            senhaTxt.SendKeys(senha);
        }

        [When(@"clico no botão Entrar")]
        public void QuandoClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();


        }

        [Then(@"vejo na tela '(.*)'")]
        public void EntaoVejoNaTela(string mensagem)
        {
            
            bool achouTexto = driver.PageSource.Contains(mensagem);
            if (!achouTexto)
            {
                mensagens.TestPostMessage("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");
                throw new Exception("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");
                    
            }
        }
        [AfterScenario]
        public void FechaBrowser()
        {
            driver.Dispose();
            mensagens.TestPostMessage("ola");
        }

        

    }
}
