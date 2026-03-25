# 🤖 Robô Tupiniquim I 2026!

##  Introdução  
A Agência Espacial Brasileira (AEB) contratou a Academia do Programador para desenvolver o software de guia do Robô Tupiniquim I, que realizará análises em Marte. O robô explora uma área representada por um grid, movimentando-se com base em comandos simples enviados pelo usuário.

## Funcionalidades  

- **Posição e Orientação**:  
  O robô possui uma posição definida por coordenadas (X, Y) e uma direção:  
  N (Norte), S (Sul), L (Leste) e O (Oeste).  

- **Sistema de Comandos**:  
  O robô recebe uma sequência de comandos:  
  - **E (Esquerda)** → gira 90° para a esquerda  
  - **D (Direita)** → gira 90° para a direita  
  - **M (Mover)** → avança uma posição no grid  

- **Execução Sequencial**:  
  Os comandos são executados na ordem informada, alterando posição e direção do robô.

- **Resultado Final**:  
  Ao final da execução, o programa mostra a posição final (X Y) e a direção do robô.

## Como funciona o programa  

- O usuário informa a posição inicial no formato:  

X Y Direção


- Em seguida, informa uma sequência de comandos, por exemplo:  

EMEMEMEMM


- O programa percorre cada comando:
- Atualiza a direção (E ou D)  
- Move o robô (M)  

- Ao final, exibe o resultado da exploração.

## Exemplo de uso  

### Entrada:

Digite a posição inicial: 1 2 N
Digite a sequência de comandos: EMEMEMEMM


### Saída esperada:

Posição alcançada: 1 3 N


## Como utilizar o programa  

1. Clone o repositório ou baixe o código em `.zip`.  
2. Abra o terminal e navegue até a pasta do projeto.  

3. Utilize o comando abaixo para restaurar as dependências:  

```bash
dotnet restore

Execute o projeto com:
dotnet run --project RoboTupiniquim.ConsoleApp
```

📋 Requisitos
```bash
.NET SDK 10.0
Terminal/Console compatível