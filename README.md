# File Loading - Trabalhando com arquivos. (Exercícios de fixação - C#)

Trabalhando com Arquivos - C#

## 🚀 Começando

Problema proposto que o programa deve resolver:

Ler o caminho de um arquivo .csv contendo os dados de itens vendidos. Cada item possui um
nome, preço unitário e quantidade, separados por vírgula. Você deve gerar um novo arquivo chamado "summary.csv", localizado
em uma subpasta chamada "out" a partir da pasta original do arquivo de origem, contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade), conforme exemplo.

### 📋 Pré-requisitos

Dietório contendo o .csv

```
Exemplo Sorce File:

TV LED,1290.99,1
Video Game Chair,350.50,3
Iphone X,900.00,2
Samsung Galaxy 9,850.00,2

```

### 🔧 Instalação

Não requer instação.

## ⚙️ Executando os testes

O programa deve reproduzir o resultado abaixo:

```
Output file (out/summary.csv)

TV LED,1290.99
Video Game Chair,1051.50
Iphone X,1800.00
Samsung Galaxy 9,1700.00

```

### 🔩 Analise os testes de ponta a ponta

Note que, o programa irá multiplicar a quantidade de produtos pelo seu preço e apresentar o resultado.

```
Exemplo:
InPut:  Video Game Chair,350.50,3
OutPut: Video Game Chair,1051.50

```

## 📦 Desenvolvimento

Para este projeto foi utilizado o visual studio 2019 comutity - Framework 5.0.
