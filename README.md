# Revisando-C-
Projetos de estudo em C#

Projeto Composições
-------------------
- Laços de repetição
- DateTime
- Foreach
- Orientação a objeto
- Lista
- Enum
- Composição

Projeto Herança e Polimorfismo
------------------------------
- StringBuilder
- Virtual
- Base

Classes e Métodos Abstratos
------------------------------
- Classes abstratas não podem ser instanciandas, se uma classe possui métodos abstratos obrigatoriamente a classe deve ser abstrata.
  - Exemplo de declaração: abstract class NomeDaClasse{...}
- Métodos abstratos é implementado quando a classe é genérica demais para conter sua implementação
- Base

Excessões
---------
- Para personalizar uma excessão cria uma classe com a excessão e extende da AplicationException
- Cláusula throw lança a exeção personalizada e corta a execução e cai no bloco catch correspondente.
  -Exemplo: throw new NameException("mensage");
- No programa utiliza o catch com a excessão criada: catch(NomeException e).

Properties e auto-properties
-----------------------------
- Quando declara uma auto-properties os metodos get e set não precisa ser implementados, porém se necessitar de uma lógica dentro deles não é possivel utiliza auto-properties.
- Exemplo projeto aula60.

System.Linq
-----------
- Delegate
  - Declara antes do nome da classe
- Multicast delegates
  - Usado para metodos void, podendo invocar mais de um metodo ex:
  - Ex.: delegate void DelegateDeclarado(int n1, int n2);
         class...
         DelegateDeclarado op = classe.metodo1;
         op += classe.metodo2;
         op(a,b);
         resultado: retorno do metodo1 + metodo2 