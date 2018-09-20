<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<!--RPM Assignment
Author: Sean Purtill
Sept 20 2018
This page handles the html and JS client side of the application
-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">


    <title>RPM Software Assignment</title>
        <script type="text/javascript">
            function jsClick() {
                // Get Value from input.
                var x = document.getElementById("tbInput").value;
                //assign value to output.
                document.getElementById("lbOutput").innerHTML = x;
                //Make sure the value is not empty
                if (x === undefined || x === null || x === "") {
                                    document.getElementById("lbOutput").innerHTML = "No Input.";

                }
                //change the size.
                document.getElementById("lbOutput").style.fontSize = "xx-large";
                //return false, preventing postback
                return false;
            }

        </script>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-atomic="True">
            
            &nbsp;&nbsp;&nbsp;
            
            <asp:Label ID="lbTitle" runat="server" Text="RPM Software Assignment" 
                Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" 
                Font-Underline="True"></asp:Label>
            <br />
            <br />
            <br />
            <asp:TextBox ID="tbInput" runat="server" Height="75px" Width="400px">Enter your Text Here.</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Label ID="lbOutput" runat="server" Text="Your Output will appear here."></asp:Label>
            <br />
            <br />
            
            <asp:Button ID="btnJS" runat="server" OnClientClick="jsClick(); return false;"  Text="JavaScript" 
                Width="200px"  />
            <asp:Button ID="btnCSharp" runat="server" OnClick="btnCSharp_Click" Text="C# " 
                Width="200px" />
            <br />
            <br />
            The Javascript Button changes the size of the font. <br />
            <br />
            The C# button changes the text into pig latin.<br />
            <br />
            
        </div>
    </form>
</body>
</html>
