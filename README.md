# 🚗 Sistema de Aluguel de Carros

Sistema de console desenvolvido em **C#** para praticar conceitos de programação orientada a objetos, manipulação de coleções e implementação de regras de negócio.

O projeto simula uma pequena locadora de veículos, permitindo cadastrar uma lista inicial de carros, consultar disponibilidade, realizar aluguéis e registrar devoluções.

---

## 📌 Sobre o Projeto

O **Sistema de Aluguel de Carros** foi desenvolvido como um projeto prático para reforçar conhecimentos em **C# e Programação Orientada a Objetos (POO)**.

A aplicação funciona através de um menu no terminal, onde o usuário pode:

* 🚘 Listar os carros disponíveis e alugados
* 🔑 Alugar um veículo
* ↩️ Devolver um veículo
* 💰 Calcular automaticamente o valor do aluguel
* 🔎 Localizar veículos através da placa
* ⚠️ Validar situações como carro inexistente ou já alugado

---

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET**
* **Console Application**
* **Programação Orientada a Objetos (POO)**
* **Collections / List<T>**
* **Lambda Expressions**
* **Properties**
* **Métodos**
* **Interpolação de strings**
* **Nullable reference handling**
* **Cálculo com `decimal`**

---

## 🧠 Conceitos de C# Praticados

### Classes e Objetos

O projeto utiliza classes para representar as principais entidades do sistema:

```csharp
public class Carro
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public bool Disponivel { get; set; } = true;
    public decimal ValorDiaria { get; set; }
}
```

E:

```csharp
public class Aluguel
{
    public string Cliente { get; set; }
    public Carro CarroAlugado { get; set; }
    public int Dias { get; set; }

    public decimal ValorTotal => CarroAlugado.ValorDiaria * Dias;
}
```

Essas classes representam as entidades principais do domínio da aplicação.

---

## 📋 Funcionalidades

### 1. Listar carros

Exibe todos os veículos cadastrados, mostrando:

* Placa
* Modelo
* Valor da diária
* Status de disponibilidade

Exemplo:

```text
ABC1234 - Onix LT - Diária: R$ 100,00 - Disponível
DEF5678 - Renegade - Diária: R$ 250,00 - Alugado
GHI9012 - HB20 - Diária: R$ 110,00 - Disponível
```

---

### 2. Alugar carro

O usuário informa:

1. Placa do veículo
2. Nome do cliente
3. Quantidade de dias

O sistema verifica se:

* O carro existe;
* O carro está disponível.

Depois do aluguel, o status do veículo é alterado para:

```text
Disponivel = false
```

O valor total é calculado automaticamente:

```text
Valor total = Valor da diária × Quantidade de dias
```

---

### 3. Devolver carro

Para realizar a devolução, o usuário informa a placa do veículo.

O sistema verifica se:

* O carro existe;
* O carro está atualmente alugado.

Após a devolução:

```text
Disponivel = true
```

---

## 🏗️ Estrutura do Projeto

Atualmente, o projeto possui uma implementação simples concentrada no arquivo principal:

```text
SistemaAluguelCarros/
│
├── Program.cs
├── SistemaAluguelCarros.csproj
└── README.md
```





## 🖥️ Menu da Aplicação

Ao executar o programa, será apresentado:

```text
=== Sistema de Aluguel de Carros ===

[1] - Listar Carros
[2] - Alugar Carro
[3] - Devolver Carro
[0] - Sair

Escolha uma opção:
```

---

## 💰 Exemplo de Aluguel

Supondo que o cliente alugue um **Onix LT** por 5 dias:

```text
Valor da diária: R$ 100,00
Quantidade de dias: 5

Valor total: R$ 500,00
```

---

## 🔎 Regras de Negócio

O sistema possui algumas regras básicas:

* Uma placa identifica o veículo.
* Um carro inexistente não pode ser alugado.
* Um carro já alugado não pode ser alugado novamente.
* Um carro disponível não pode ser devolvido.
* O status do carro é alterado durante o aluguel e a devolução.
* O valor do aluguel é calculado com base na diária e na quantidade de dias.

---

## 🚀 Possíveis Melhorias

Este projeto foi desenvolvido inicialmente como exercício de C#, mas possui espaço para evolução.

### Próximas funcionalidades

* [ ] Cadastro de novos carros
* [ ] Remoção de veículos
* [ ] Cadastro de clientes
* [ ] Histórico de aluguéis
* [ ] Persistência em banco de dados
* [ ] Sistema de login
* [ ] Validação de entrada de dados
* [ ] Tratamento de exceções
* [ ] Relatório de veículos alugados
* [ ] Relatório de faturamento
* [ ] Data de retirada e devolução
* [ ] Cálculo de multas por atraso
* [ ] Aplicação de descontos
* [ ] Testes unitários
* [ ] API REST com ASP.NET Core
* [ ] Interface web com React

---



## 👨‍💻 Autor

**Diego Santos**


