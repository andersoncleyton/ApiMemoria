# ApiMemoria
Exemplo de API REST em dotNet Core
Neste exemplo simula uma API para realizar o cadastro de filme e categoria.
Todos os dados cadastrados são salvo em mémoria.

JSON Para testar:

//Categoria
//URL - https://localhost:5001/Categoria (POST - Cadastra / GET - Lista)
{
	"Id":1
	,"Nome":"Ação"
}

//Filme
//URL - https://localhost:5001/Filme (POST - Cadastra / GET - Lista)
{
	"Titulo":"Os Goonies"
	,"Descricao":"Os Goonies encontram um misterioso mapa do tesouro e começam a seguir as pistas, entrando em um fabuloso mundo subterrâneo de passagens secretas, perigosas armadilhas e um antigo galeão pirata que esconde moedas de ouro."
	,"Ano":1985
	,"CategoriaId":1
}

