using System;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;   
        private IWebDriver driver; // Objeto do Selenium
        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            new driverManager().SetUpDriver(new ChromeConfig()); // Instanciando o ChromeDriver através do webDriverManage
            driver = new ChromeDriver(); // Instanciou o Selenium como Chrome
            driver.Manage().Timeouts().ImplicitQait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); // Encerrou o selenium
        }
        [Given(@"que acesso a página inicial do site")]      
        public void GivenQueAcessoAPaginaInicialDoSite()     
        {
            _scenarioContext.Pending();
        }

        [Given(@"adiciono o produto ""(.*)"" ao carrinho")]  
        public void GivenAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [Given(@"clico no icone do carrinho de compras")]    
        public void GivenClicoNoIconeDoCarrinhoDeCompras()   
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuário como ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string p0)      
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]   
        public void WhenASenhaEClicoNoBotaoLogin(string p0)  
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]       
        public void ThenExibeNoTituloDaSelecao(string products0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void ThenExibeAPaginaDoCarrinhoComAQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o nome do produto ""(.*)""")]
        public void ThenONomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)""")]
        public void ThenOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}