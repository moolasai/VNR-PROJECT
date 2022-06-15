<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validations.aspx.cs" Inherits="login_assignment.validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <th>
                    Username

                </th>
                <td>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validate" runat="server" ControlToValidate="txtuser" ErrorMessage="U have given Wrong input" ForeColor="YellowGreen"></asp:RequiredFieldValidator>
                </td>
            </tr>
           <tr>
               <th>
                   Password
               </th>
               <td>
                   <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpass" ErrorMessage="Wrong input" ForeColor="YellowGreen"></asp:RequiredFieldValidator>
               </td>
           </tr>
            <tr>
                <td>
                    <asp:Button ID="subbtn" runat="server" Text="SUBMIT" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Countries :
            <asp:DropDownList ID="ddlcountry" runat="server" OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged"
                AutoPostBack="true" AppendDataBoundItems="true">
            </asp:DropDownList>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlcountry" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            States :
            <asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
            </asp:DropDownList>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlstate" />
        </Triggers>
    </asp:UpdatePanel>


                </td>
            </tr>

        </table>
    </form>
</body>
</html>
