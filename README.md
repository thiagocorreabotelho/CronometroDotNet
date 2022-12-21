# Crônometro .NET

Seja bem vindo(a) ao nosso rep Cronômetro .NET, segue abaixo o que é preciso fazer para desenvolver um cronômetro do zero com console.

## Requisitos
- Preciso que seja criada uma aplicação cru do console c#.
- Quando o usuário entrar em nossa aplicação, ele recebera na tela uma mensagem de boas vindas e logo em seguida as opções para selecionar no menu.
- O usuário deverá informar para a aplicação o tempo e o tipo se é segundo ou menutos que ele deseja.
- Finalizando a aplicação, o mesmo terá que exibir o menu novamente para o usuário.

---

# Resolução do problema

A primeira coisa que devemos fazér é criar um método chamado menu e chamar em nosso método principal **main**.

```csharp
     static void Main(string[] args)
     {
            Menu();
     }

     static void Menu()
     {
            


            Console.WriteLine("------ SEJA BEM VINDO(A) AO NOSSO CRONÔMETRO .NET CORE ------");
            Console.WriteLine();
            Console.WriteLine("SELECIONE ABAIXO O QUE VOCÊ DESEJA FAZER!");
            Console.WriteLine("LEMBRANDO QUE VOCÊ DEVE INFORMAR O TEMPO MAIS O TIPO EXEMPLO: 10S OU 10M");
            Console.WriteLine();
            Console.WriteLine("S = SEGUNDOS");
            Console.WriteLine("M = MINUTOS");
            Console.WriteLine("0 = SAIR");
            Console.WriteLine("QUANTO TEMPO DESEJA CONTAR?");

            string valorDigitado = Console.ReadLine().ToLower();
            char tipo = char.Parse(valorDigitado.Substring(valorDigitado.Length - 1, 1));
            int tempo = int.Parse(valorDigitado.Substring(0, valorDigitado.Length - 1));
            int multiplicacao = 1;

            if (tipo == 'm')
                multiplicacao = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            Calculo((tempo * multiplicacao));
     }
```

> **Explicação**: Observe acima que após o menu de strings a primeira coisa que vamos fazer é atribuir dentro da variável o valor que o nosso usuário digitou.
Na mesma linha estamos utilizando o método ToLower(), para deixar todos os caracteres digitado de forma minuscula e assim facilitando na hora de realizar condições.

> **Explicação char**: Agora o que devemos fazer é pegar o valor que esta em nossa variável _valorDigitado_ e "quebrar" convertendo em tempo e tipo. Neste caso vamos primeiro pegar o tipo que o nosso usuário digitou e para isso pegamos o que o usuário nos passou se foi s de segundos ou m de minutos. 
Observe que na mesma linha da conversão utilizamos o método Substring para pegar o ultimo valor e guardar em nossa variável.

> **Explicação tempo**: A mesma lógica que foi aplicada para o tipo, vamos aplicar para o tempo o que vai mudar é que o tempo foi feita em números inteiros e não char, na parte em que utilizamos o Substring, vamos fazer ao contrário ao inves de pegar o ultimo, vamos informar que vamos pegar o caractere a partir do 0 e ignorar o ultimo fazendo o inverso.

Agora precisamos verificar 2 coisas, caso o tipo seja **M** devemos informar para nossa váriavel _multiplicacao_ que ela terá 60s que é equivalente a 1 minuto cada 60 segundos e caso o tempo seja 0, iremos encerrar a aplicação.

Observe que logo após a nossa verificação, temos o método que faz o calculo e nele passamos como assinatura o tempo que desejamos seja em m ou s.

```csharp
    static void Calculo(int tempo)
    {
            int meuTempo = 0;

            while (meuTempo != tempo)
            {
                Console.Clear();
                meuTempo++;
                Console.WriteLine(meuTempo);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Fim");
            Thread.Sleep(2500);
            Menu();
   }
```

Logo acima é bem tranquilo de entender nosso método que faz o calculo do tempo, o tempo estamos recebendo via assinatura do método o que já vai nos facilitar.
é preciso criar uma nova variável que foi nomeada como meuTempo que vai ter seu inicializador como 0.

Agora para chegar no resultado que queremos devemos utilizar o While ou seja faça enquanto isso for diferente disto.
Enquanto meu tempo dor diferente do tempo passado via assinatura acrescente 1 em 1 até chegar no tempo que recebemos no parametro.
Depois fim e vamos exibir novamente nosso menu para o usuário.
