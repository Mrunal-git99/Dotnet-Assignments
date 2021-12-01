<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="MasterPageDemo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="empno" DataSourceID="SqlDataSource1" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
            <asp:BoundField DataField="empname" HeaderText="empname" SortExpression="empname" />
            <asp:BoundField DataField="designation" HeaderText="designation" SortExpression="designation" />
            <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
            <asp:BoundField DataField="deptno" HeaderText="deptno" SortExpression="deptno" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDepartmentDBConnectionString %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
</asp:Content>
