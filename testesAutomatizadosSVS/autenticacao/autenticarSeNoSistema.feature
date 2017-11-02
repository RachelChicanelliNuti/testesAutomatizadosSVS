Funcionalidade: Autenticação no sistema
Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil

Esquema do Cenário: Autenticação com sucesso
	Dado que estou na página de autenticacao 
	Quando eu preencho o campo CPF com o valor <cpf>
	E preencha o campo Senha com o valor <senha>
	Quando clico no botão Entrar
	Então vejo na tela <mensagem>

	Exemplos:
	| cpf           | senha        | mensagem             |
	| '11111111111' | '1111111111' | 'selecione o perfil' |
	| '22222222222' | '2222222222' | ''                   |
	| '99999999999' | ''           | 'Senha obrigatório'  |
	| ''            | '1111111111' | 'CPF obrigatório'    |
	
