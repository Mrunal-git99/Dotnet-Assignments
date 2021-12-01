<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RepeatersASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDepartmentDBConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>Department Table
                <br />
                <table border="1">
                    <thead>
                        <th>Department ID</th>
                         <th>Department Name</th>
                         <th>Department Location </th>

                    </thead>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                        <td><asp:Label ID="Label1" runat="server" Text='<%#Bind("deptno")%>'></asp:Label></td>
                        <td><asp:Label ID="Label2" runat="server" Text='<%#Bind("deptname")%>'></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("location")%>'></asp:Label></td>
                    
                </tr>
            </ItemTemplate>

            <AlternatingItemTemplate>
                <tr style="background-color:aquamarine">
                     <td><asp:Label ID="Label1" runat="server" Text='<%#Bind("deptno")%>'></asp:Label></td>
                        <td><asp:Label ID="Label2" runat="server" Text='<%#Bind("deptname")%>'></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("location")%>'></asp:Label></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>                     
                </table>
                <h2>Department Records   </h2>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
