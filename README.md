# 💳 XYZ Administradora de Cartões de Crédito

Sistema completo para **cadastro e gerenciamento de transações de cartão de crédito**, desenvolvido em **VB.NET** com **SQL Server**.  
Focado em **eficiência, confiabilidade** e **escalabilidade** no processamento de dados financeiros.

---

## 📘 Visão Geral

A XYZ Administradora precisava de uma solução robusta para o controle de transações financeiras dos clientes.  
Este sistema foi desenvolvido para atender com segurança, organização e boa performance.

---

## ⚙️ Funcionalidades Principais

### ✅ CRUD de Transações
- Cadastrar, consultar, editar (exceto transações aprovadas) e excluir transações.
- Validação dos campos:
  - `Id_Transacao` (gerado automaticamente)
  - `Numero_Cartao` (16 dígitos)
  - `Valor_Transacao` (decimal positivo)
  - `Data_Transacao` (data/hora)
  - `Descricao` (até 255 caracteres)
  - `Status_Transacao` (Aprovada, Pendente, Cancelada)
- Filtros: número do cartão, data, valor, status.
- Exibição em `DataGrid` com paginação otimizada.

### 🛡️ Tratamento de Erros e Logs
- Exibição de mensagens amigáveis ao usuário.
- Log detalhado de exceções salvo em arquivos `.log`.

### 🗃️ SQL Server Avançado
- `Stored Procedure`: totalização de transações por período e status.
- `Scalar Function`: categorização de valores.
- `Table-Valued Function (TVF)`: listagem de transações com categorias.
- `View`: consolidação de dados para relatórios.

### 📤 Exportação para Excel
- Exportação de transações do último mês para arquivo `.xlsx`.

---

## 🧩 Requisitos

- Visual Studio 2022  
- .NET Framework 4.7.2 ou superior  
- SQL Server 2016 ou superior

---

## 🚀 Como Executar

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
