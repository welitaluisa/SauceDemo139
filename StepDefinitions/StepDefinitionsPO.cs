using TechTalk.SpecFlow;

namespace MyNamespace
{
    public class SelectProdutPO
    {
    
        [Given(@"que acesso a página inicial do site PO")]
        public void DadoQueAcessoAPaginaInicialDoSitePO()
        {
        
        }

        [When(@"preencho o ""(.*)"" PO")]
        public void QuandoPreenchoOPO(string p0)
        {
        
        }

        [When(@"a senha ""(.*)"" e clico no botao Login PO")]
        public void QuandoASenhaEClicoNoBotaoLoginPO(string p0)
        {
        
        }

        [Then(@"exibe ""(.*)"" no titulo da secao PO")]
        public void EntaoExibeNoTituloDaSecaoPO(string products0)
        {
        
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho PO")]
        public void QuandoAdicionoOProdutoAoCarrinhoPO(string p0)
        {
        }

        [When(@"clico no icone do carrinho de compras PO")]
        public void QuandoClicoNoIconeDoCarrinhoDeComprasPO()
        {
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)"" PO")]
        public void EntaoExibeAPaginaDoCarrinhoComAQuantidadePO(string p0)
        {
        }

        [Then(@"nome do produto ""(.*)"" PO")]
        public void EntaoNomeDoProdutoPO(string p0)
        {
        }

        [Then(@"o preco como ""(.*)"" PO")]
        public void EntaoOPrecoComoPO(string p0)
        {
        }
    }
}