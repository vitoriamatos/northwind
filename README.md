# Projeto Northwind
Projeto desenvolvido para a disciplina de Banco de Dados 2. O projeto consiste em um sistema de ecommerce cujas funcionalidades são:
* CRUD  de clientes
* Sistema de compra de produtos
* Exibição de produtos
* Exibição de compras feitas
* Detalhamento da compra
* Exibição de compras feitas na região do rio de janeiro (procedure)

> Obs: todas as funcionalidades foram requeridas na ativdade postada no Classroom da disciplina

## Especificações

* Para rodar o projeto é necessário ter o *Visual Studio Comunity* 2019 instalado bem como os pacotes de `c# e asp.net`
* É necesário ter Sql server 2019 devidamente instalado e configurado 
* É necessário ter o Microsoft SQL Management Studio 

## Instalação

* Configurando o banco:
  * No diretório do projeto existe o arquivo `northwindSQL.sql`, nele está o banco de dados com a procedure e especificações necessárias para rodar aplicação
  * Você deve configurar o script no seu Microsoft SQL Management Studio 

* Configurando a aplicação: 
  * Faça o clone do repositório atráves do seguinte comando
  ```
  git clone https://github.com/vitoriamatos/northwind.git
  ```

  * Va até o diretório do clone e procure por um arquivo chamado  `ProjetoNorthwind.sln` e clique duas vezes
  * Será aberto uma janela do visual studio 2019
  * Va até o diretório `\northwind\ProjetoNorthwind\` e procure pelo arquivo `appsettings.json` e renomei o servidor para o seu server onde está instalado o banco de dados do projeto:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Data Source=<seu_server>;Initial Catalog=Northwind;Integrated Security=True"
    },
  ```
  * Procure pelo ícone do play verde e clique nele, assim será possivel executar o projeto 

## Desenvolvedores

Maria Vitória, João Thalis e João Pedro Ventura
