# Teste prático - Desenvolvimento .Net (C#)

Parabéns! Você chegou até o nosso teste para desenvolvedores .Net e linguagem C#!

Realizamos este teste para avaliarmos o seu nível de conhecimento em tecnologias e desafios que você virá a encontrar caso faça parte da nossa equipe.

Para isso, preparamos um teste prático de rápido desenvolvimento, mas que é mais do que suficiente para nos introduzir a quem você é escrevendo código: sua organização de projeto, formatação, arquitetura e conceitos de desenvolvimento. 🤘  


## Contexto

O teste é composto de três aplicações, sendo:

**TimeApi**: O TimerApi é uma API Rest em .NET Core que possui um método GET que retorna um DateTime atual. Antes de retornar o DateTime, ele usa um delay aleatório de 1s até 10s a fim de simular uma API com problemas de performance.

**Portal**: O Portal é uma aplicação ASPNET Core que possui 1 action, Index, que é responsável por gerar uma chave aleatória, usando as informações obtidas da TimeApi. A aplicação Portal possui uma restrição de threads disponíveis para simular um servidor com alta carga de trabalho.
No projeto Portal, há uma propriedade estática na classe Program, a NUMBER_OF_VIRTUAL_MACHINES, que simula a quantidade de máquinas utilizadas para atender as requisições.
A simulação utiliza a fórmula (Número de Cores * NUMBER_OF_VIRTUAL_MACHINES) para restringir o número de threads da aplicação Portal, ou seja, 1 máquina da simulação é igual a 8 threads.
Ex.: Se a máquina possui 8 cores e NUMBER_OF_VIRTUAL_MACHINES = 10, então a aplicação Portal simula a utilização de 10 máquinas e poderá utilizar até 80 threads.

**Requester**: O Requester é uma aplicação console em .NET Core que faz chamadas paralelas para o Portal.


*O seu objetivo é refatorar a aplicação, que é funcional, para utilizar o MENOR número possível em NUMBER_OF_VIRTUAL_MACHINES para atender no mínimo 50 requisições simultaneas sem receber BadRequest.*


## Requisitos

- A aplicação está funcional. Quando voce acessar http://localhost:5000/Home será calculado uma chave e retornará as informações do processo.
- NUMBER_OF_VIRTUAL_MACHINES deve ser no mínimo 1, ou seja, simular a utilização de no mínimo um servidor.
- A configuração default de NUMBER_OF_VIRTUAL_MACHINES é 50, o que garante o funcionamento da aplicação e simula uma estrutura de infraestrutura superdimensionada.
- Você não possui gestão sobre a **TimeAPI**, então, **não poderá alterar o seu código fonte**.
- **Seu objetivo é refatorar a aplicação Portal**.
- Você pode refatorar a aplicação Requester, caso julgue necessário.
- Use o tempo que achar necessário.
- Ao finalizar o teste, envie o link do repositório Git, onde todo o teste e suas alterações deverão estar comitados.

Só temos mais um pedido: encare este projeto como algo que você encontraria em seu dia-a-dia profissional, ou como um projeto de estimação. Em outras palavras, queremos que você sinta prazer programando e que você se dedique ao projeto como se fosse seu. O resto é por sua conta 😬

## Submissão

- Criar um repositório privado no Gitlab, compartilhando-o com o usuário @jeferson.raupp-portaldomedico (com permissão Developer).

## Contato

Buscamos o máximo de clareza possível ao documentar o exercício, e esperamos que todas as dúvidas possam ser solucionadas com este `README`. Mas as dúvidas virão e estamos prontos! Fique à vontade para entrar em contato conosco através do endereço [jeferson@portaldomedico.com](mailto:jeferson@portaldomedico.com) para tirar dúvidas e pedir ajuda. Pedimos apenas que as dúvidas sejam pertinentes ao exercício, para que possamos dar toda a atenção necessária a todos os candidatos.