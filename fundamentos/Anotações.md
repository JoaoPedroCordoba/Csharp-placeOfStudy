# 📘 Anotações de Fundamentos do C#

## 🟢 O que é C#?

**C# (C Sharp)** é uma linguagem de programação moderna, orientada a objetos, criada pela urlMicrosoft[https://www.microsoft.com/](https://www.microsoft.com/). Ela é amplamente utilizada para:

* Aplicações de console
* Aplicações desktop
* APIs Web
* Aplicações com urlASP.NET Core[https://dotnet.microsoft.com/apps/aspnet](https://dotnet.microsoft.com/apps/aspnet)
* Jogos com urlUnity[https://unity.com/](https://unity.com/)
* Aplicativos mobile

---

## ⚙️ Estrutura Básica de um Programa

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");
    }
}
```

### 📌 Explicação

* `using System;` → importa funcionalidades básicas.
* `class Program` → define uma classe.
* `Main()` → ponto de entrada do programa.
* `Console.WriteLine()` → exibe texto no console.

---

# 📦 Variáveis

Variáveis armazenam valores na memória.

```csharp
string nome = "João";
int idade = 25;
double altura = 1.75;
bool ativo = true;
```

---

## 🧠 Principais Tipos de Dados

| Tipo       | Exemplo        | Descrição                 |
| ---------- | -------------- | ------------------------- |
| `int`      | `10`           | Número inteiro            |
| `double`   | `3.14`         | Número decimal            |
| `decimal`  | `19.99m`       | Decimal com alta precisão |
| `string`   | `"Olá"`        | Texto                     |
| `char`     | `'A'`          | Um único caractere        |
| `bool`     | `true`         | Verdadeiro ou falso       |
| `DateTime` | `DateTime.Now` | Data e hora               |

---

# 🔄 Constantes

```csharp
const double PI = 3.14159;
```

O valor não pode ser alterado após a declaração.

---

# ➕ Operadores Aritméticos

```csharp
int soma = 10 + 5;
int sub = 10 - 5;
int mult = 10 * 5;
int div = 10 / 5;
int resto = 10 % 3;
```

---

# ⚖️ Operadores Relacionais

```csharp
10 > 5   // true
10 < 5   // false
10 == 5  // false
10 != 5  // true
10 >= 5  // true
10 <= 5  // false
```

---

# 🔗 Operadores Lógicos

```csharp
&&  // E
||  // OU
!   // NÃO
```

Exemplo:

```csharp
bool resultado = idade >= 18 && ativo;
```

---

# ⌨️ Entrada e Saída de Dados

## 📤 Mostrar informações

```csharp
Console.WriteLine("Olá!");
Console.Write("Digite seu nome: ");
```

## 📥 Ler informações

```csharp
string nome = Console.ReadLine();
```

## 🔢 Converter valores

```csharp
int idade = int.Parse(Console.ReadLine());
double preco = double.Parse(Console.ReadLine());
```

### ✅ Conversão segura

```csharp
if (int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine($"Número válido: {numero}");
}
```

---

# 🔀 Estruturas Condicionais

## if / else

```csharp
if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}
```

## else if

```csharp
if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
```

## switch

```csharp
switch (dia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}
```

---

# 🔁 Estruturas de Repetição

## for

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## while

```csharp
int contador = 1;
while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}
```

## do while

```csharp
int numero;
do
{
    Console.Write("Digite um número positivo: ");
    numero = int.Parse(Console.ReadLine());
}
while (numero <= 0);
```

## foreach

```csharp
string[] nomes = { "Ana", "Carlos", "Maria" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
```

---

# 🧩 Métodos

Métodos organizam o código e evitam repetições.

```csharp
static void Saudacao()
{
    Console.WriteLine("Olá!");
}
```

## Método com parâmetros

```csharp
static void Saudacao(string nome)
{
    Console.WriteLine($"Olá, {nome}!");
}
```

## Método com retorno

```csharp
static int Somar(int a, int b)
{
    return a + b;
}
```

---

# 🧵 Interpolação de Strings

```csharp
string nome = "João";
int idade = 25;

Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos.");
```

---

# 📚 Arrays

```csharp
int[] numeros = { 10, 20, 30 };

Console.WriteLine(numeros[0]); // 10
```

### Propriedade `Length`

```csharp
Console.WriteLine(numeros.Length);
```

---

# 📋 Listas (`List<T>`)

```csharp
using System.Collections.Generic;

List<string> frutas = new List<string>();
frutas.Add("Maçã");
frutas.Add("Banana");
frutas.Remove("Maçã");
```

---

# 📅 DateTime

```csharp
DateTime agora = DateTime.Now;
Console.WriteLine(agora);
```

---

# 🎯 Enum

```csharp
enum StatusPedido
{
    Pendente,
    Pago,
    Enviado
}
```

---

# ❗ Tratamento de Exceções

```csharp
try
{
    int numero = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("Formato inválido.");
}
finally
{
    Console.WriteLine("Fim da operação.");
}
```

---

# 📝 Comentários

```csharp
// Comentário de uma linha

/*
   Comentário
   de várias linhas
*/
```

---

# 🏗️ Convenções de Nomenclatura

| Elemento   | Convenção  | Exemplo           |
| ---------- | ---------- | ----------------- |
| Classes    | PascalCase | `PessoaFisica`    |
| Métodos    | PascalCase | `CalcularTotal()` |
| Variáveis  | camelCase  | `nomeCompleto`    |
| Constantes | PascalCase | `TaxaJuros`       |

---

# 🧪 Exemplo Completo

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine($"{nome}, você é maior de idade.");
        }
        else
        {
            Console.WriteLine($"{nome}, você é menor de idade.");
        }
    }
}
```

---

# 🚀 Próximos Tópicos

Depois de dominar os fundamentos, estude:

1. Classes e Objetos
2. Encapsulamento
3. Herança
4. Polimorfismo
5. Interfaces
6. LINQ
7. ASP.NET Core

---

# 📚 Recursos Oficiais

* urlDocumentação do C#[https://learn.microsoft.com/dotnet/csharp/](https://learn.microsoft.com/dotnet/csharp/)
* urlMicrosoft Learn – Primeiros passos com C#[https://learn.microsoft.com/training/paths/csharp-first-steps/](https://learn.microsoft.com/training/paths/csharp-first-steps/)
* urlDownload do .NET SDK[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

---

# ✅ Checklist de Estudos

* [ ] Variáveis e tipos
* [ ] Operadores
* [ ] Condicionais
* [ ] Laços de repetição
* [ ] Métodos
* [ ] Arrays e listas
* [ ] Tratamento de exceções
* [ ] Enum e DateTime

---

> 📌 Dica: pratique cada tópico escrevendo pequenos programas. A repetição é uma das formas mais eficazes de consolidar o aprendizado.
