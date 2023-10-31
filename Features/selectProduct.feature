Feature:
functionality: Selecionar Produto na Loja 
    @Loja
    Scenario: Selecao de Produto com Sucesso
    Given que acesso a página inicial do site
    When preencho o usuário como "secret_sauce"
    And a senha "sauce_secret" e clico no botao Login
    Then exibe "Products" no titulo da Selecao
    Given adiciono o produto "Sauce Labs Backpack" ao carrinho
    And clico no icone do carrinho de compras
    Then exibe a pagina do carrinho com a quantidade "1"
    And o nome do produto "Sauce Labs Backpack"
    And o preco como "$29.99"    