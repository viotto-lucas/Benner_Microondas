Micro-ondas Digital:
Este projeto implementa um micro-ondas digital utilizando ASP.NET Core para a parte web e C# para a lógica de backend. O sistema permite que os usuários informem o tempo e a potência do aquecimento, além de fornecer funcionalidades adicionais como início rápido, pausa e cancelamento do aquecimento.

Requisitos Atendidos:
Este projeto atende aos requisitos do Nível 1. Abaixo estão os detalhes das funcionalidades implementadas.

Funcionalidades Implementadas:
Interface do Usuário:
- Formulário para entrada de tempo e potência.
- Opções de input via teclado digital e teclado comum.

Aquecimento:
- Método para iniciar o aquecimento com tempo e potência parametrizáveis.
- O tempo pode variar de 1 segundo a 2 minutos, e a potência de 1 a 10 (com 10 como padrão).

Validações:
- Mensagens de erro exibidas para tempos ou potências inválidas.
- Potência padrão (10) utilizada quando não informada pelo usuário.

Início Rápido:
- Permite iniciar o aquecimento com potência máxima (10) e 30 segundos por padrão, sem a necessidade de entrada adicional.

Acréscimo de Tempo:
- O usuário pode adicionar 30 segundos ao aquecimento em andamento.

Feedback de Aquecimento:
- Exibe uma string de progresso durante o aquecimento, que varia com a potência.
  
Pausa e Cancelamento:
- Botão para pausar e cancelar o aquecimento, com lógica para retomar ou limpar os dados conforme necessário.
  
Tecnologias Utilizadas:
ASP.NET Core: Para desenvolvimento da aplicação web.
C#: Para a lógica de negócios.
HTML/CSS: Para a estrutura e estilo da interface.
JavaScript: Para manipulação da interface e interações em tempo real.
Estrutura do Projeto.

O projeto é organizado da seguinte forma:
Controllers/: Contém a lógica do controlador MicroondasController.cs.
Models/: Define o modelo Microondas.cs que contém as propriedades e métodos relacionados ao aquecimento.
Views/: Contém as views, incluindo Index.cshtml que serve como a interface principal.
wwwroot/: Contém arquivos estáticos, como CSS e JavaScript.

Considerações Finais:
Este projeto é uma implementação inicial e pode ser expandido para atender aos requisitos dos níveis superiores, como gerenciamento de histórico de aquecimentos, ajustes mais finos de potência e tempos, e uma interface ainda mais aprimorada.
