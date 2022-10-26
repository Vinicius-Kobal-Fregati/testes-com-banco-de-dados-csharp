# testes-com-banco-de-dados-csharp
Projeto realizado no curso Testes em .NET: integrando a aplicação com um banco de dados, presente na Alura.  
Esse curso foi ministrado pelo professor André Bessa.

## Sobre o projeto
No início recebemos uma aplicação de banco, a ByteBank, ela foi dividida utilizando o paradigma DDD (Domain Drive Design), dessa forma o código ficou dividido nas seguintes camadas: domínio, aplicação, infraestrutura, apresentação e testes.  
As tecnologias utilizadas foram: banco de dados MySQL, Dependency Injection, Entity Framework, Moq e xUnit.

## Conceitos aprendidos 
 - Noção do paradigma DDD.
 - Utilização do banco de dados MySQL, criação e aplicação de migrations.
 - Teste de integração para validar a conexão com o serviço de banco de dados.
 - Injetar dependência no construtor de uma classe, utilizando o DependencyInjection.
 - Testar operações de Select.
 - Testar principais operações de CRUD (adição, atualização e remoção), além do recebimento.
 - Testar exceções.
 - Testes utilizando mock, através da biblioteca Moq.
 - Testes com stubs para analisar retornos previstos, através de um objeto fake.
 - A importância de criar e se trabalhar com repositórios de dados fakes no projeto de testes.
 - Padronização de testes, como sua nomenclatura.
