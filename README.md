===============================================
XYZ Administradora de Cartões de Crédito
===============================================

Sistema completo para cadastro e gerenciamento de transações de cartão de crédito, 
desenvolvido em VB.NET com SQL Server. Projetado para oferecer robustez, desempenho 
e segurança no processamento de grandes volumes de dados financeiros.

-----------------------------------------------
Contexto
-----------------------------------------------

A XYZ Administradora de Cartões de Crédito precisava de uma solução escalável e 
confiável para o gerenciamento de transações financeiras de seus clientes. Este 
sistema foi desenvolvido para atender a essa demanda com eficiência, organização 
e facilidade de uso.

-----------------------------------------------
Funcionalidades
-----------------------------------------------

[1] Gerenciamento de Transações (CRUD)
- Cadastro, edição (exceto transações aprovadas), exclusão com confirmação e consulta.
- Validações aplicadas aos campos:
    - Id_Transacao (gerado automaticamente)
    - Numero_Cartao (16 dígitos)
    - Valor_Transacao (decimal positivo)
    - Data_Transacao (data/hora)
    - Descricao (máx. 255 caracteres)
    - Status_Transacao (Aprovada, Pendente, Cancelada)
- Filtros por: número do cartão, data, valor e status.
- Resultados exibidos em DataGrid com paginação otimizada.

[2] Tratamento de Erros e Logs
- Mensagens de erro amigáveis ao usuário.
- Log detalhado salvo em arquivos locais para diagnóstico.

[3] Integração com SQL Server
- Stored Procedure: totalização de transações por período e status.
- Scalar Function: categorização automática de valores.
- Table-Valued Function (TVF): listagem de transações categorizadas.
- View consolidada para relatórios financeiros.

[4] Exportação para Excel
- Exporta automaticamente as transações do último mês para arquivo .xlsx.

-----------------------------------------------
Requisitos
-----------------------------------------------

- Visual Studio 2022
- .NET Framework 4.7.2 ou superior
- SQL Server 2016 ou superior

-----------------------------------------------
Instalação e Execução
-----------------------------------------------

1. Clone o repositório:
   git clone https://github.com/seu-usuario/seu-repositorio.git

2. Configure o banco de dados:
   Execute o script SQL/ScriptSQL.sql para criar as tabelas, procedures, functions, 
   views e dados de exemplo.

3. Ajuste a string de conexão:
   No arquivo App.config, configure a string de conexão com seu SQL Server.

4. Abra o projeto no Visual Studio 2022 e execute.

-----------------------------------------------
Estrutura do Projeto
-----------------------------------------------

/Forms       -> Telas da aplicação (CRUD, login, consultas)
/Shared      -> Utilitários e classes auxiliares (ex: log de erros)
/SQL         -> Scripts SQL (procedures, functions, views)
/Relatorios  -> Exemplo de relatório gerado em Excel

-----------------------------------------------
Exemplo de Uso
-----------------------------------------------

- Cadastre, edite e exclua transações conforme regras de negócio.
- Filtre e consulte transações no sistema.
- Gere relatórios via views e TVFs diretamente no SQL Server.
- Exporte dados para Excel com facilidade.

-----------------------------------------------
Licença
-----------------------------------------------

Este projeto foi desenvolvido exclusivamente para fins de avaliação técnica.
Distribuição ou uso comercial não é permitido.
