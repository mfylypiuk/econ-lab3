<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Constructor.aspx.cs" Inherits="econ_lab3.Constructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="826px" Width="614px" OnFinishButtonClick="Wizard1_FinishButtonClick">
        <StepStyle Width="300px" Height="100px"/>
        <FinishNavigationTemplate>
            <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
            <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />
        </FinishNavigationTemplate>
        <WizardSteps>
            <asp:WizardStep runat="server" title="Contact Information">
                <br />
                Фамілія<br />
                <asp:TextBox ID="TextBox1" runat="server" Width="280px">Fylypiuk</asp:TextBox>
                <br />
                <br />
                Імя<br />
                <asp:TextBox ID="TextBox2" runat="server" Width="280px">Maksym</asp:TextBox>
                <br />
                <br />
                E-mail<br />
                <asp:TextBox ID="TextBox3" runat="server" Width="280px">mfylypiuk@gmail.com</asp:TextBox>
                <br />
                <br />
                Адреса<br />
                <asp:TextBox ID="TextBox4" runat="server" Width="280px">Chernivtsi city, F.Poletaeva street, 11A</asp:TextBox>
                <br />
                <br />
                Телефон<br />
                <asp:TextBox ID="TextBox5" runat="server" Width="280px">+380505111870</asp:TextBox>
                &nbsp;<br />
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Objectives">
                Цілі та мета<br />(<span lang="UK">загальний опис вас як спеціаліста у 3-5 речень</span>)<br />
                <asp:TextBox ID="TextBox6" runat="server" Height="100px" Width="280px" TextMode="MultiLine">Improve the world of information technology</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Work Experience">
                <br />
                Місце роботи та посада<br />
                <asp:TextBox ID="TextBox10" runat="server" Height="30px" TextMode="MultiLine" Width="280px">AMC Bridge
Software Engineer</asp:TextBox>
                <br />
                <br />
                Період<br />
                <asp:TextBox ID="TextBox11" runat="server" Height="30px" Width="130px" AutoCompleteType="Cellular">06/02/2019</asp:TextBox>
                -
                <asp:TextBox ID="TextBox31" runat="server" Height="30px" Width="130px">now</asp:TextBox>
                <br />
                <br />
                Обов&#39;язки/Проект<br />
                <asp:TextBox ID="TextBox12" runat="server" Height="100px" TextMode="MultiLine" Width="280px">OSM Buildings Parser
The parser is developed in C #, works with the MS SQL Server database using the Entity Framework.
The main functionality of the project is parsing OSM (XML) files and entering the necessary data into the database. The parser can work with huge files with high speed of execution and a small amount of RAM used.
</asp:TextBox>
                <br />
                <hr />
                Місце роботи<br />
                <asp:TextBox ID="TextBox27" runat="server" Height="30px" TextMode="MultiLine" Width="280px"></asp:TextBox>
                <br />
                <br />
                Період<br />
                <asp:TextBox ID="TextBox8" runat="server" Height="30px" Width="130px"></asp:TextBox>
                -
                <asp:TextBox ID="TextBox9" runat="server" Height="30px" Width="130px"></asp:TextBox>
                <br />
                <br />
                Обов&#39;язки/Проект<br />
                <asp:TextBox ID="TextBox29" runat="server" Height="100px" TextMode="MultiLine" Width="280px"></asp:TextBox>
                <br />
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Education">
                ВНЗ<br />
                <asp:TextBox ID="TextBox13" runat="server" Width="280px">Chernivtsi National University</asp:TextBox>
                <br />
                <br />
                Спеціальність<br />
                <asp:TextBox ID="TextBox14" runat="server" Width="280px">Software Engineering</asp:TextBox>
                <br />
                <br />
                Ступінь<br />
                <asp:TextBox ID="TextBox15" runat="server" Width="280px">Bachelor</asp:TextBox>
                <br />
                <br />
                Період<br />
                <asp:TextBox ID="TextBox7" runat="server" Height="30px" Width="130px">01/09/2018</asp:TextBox>
                -
                <asp:TextBox ID="TextBox28" runat="server" Height="30px" Width="130px">01/07/2020</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Skills">
                <br />
                Мови програмування та технології<br />
                <asp:TextBox ID="TextBox16" runat="server" TextMode="MultiLine" Height="100px" Width="280px">C#
JavaScript 
TypeScript 
</asp:TextBox>
                <br />
                <br />
                Фреймворки<br />
                <asp:TextBox ID="TextBox17" runat="server" TextMode="MultiLine" Height="100px" Width="280px">Entity Framework</asp:TextBox>
                <br />
                <br />
                Бази даних<br />
                <asp:TextBox ID="TextBox18" runat="server" TextMode="MultiLine" Height="100px" Width="280px">MySQL
MS SQL Server
</asp:TextBox>
                <br />
                <br />
                Засоби розробки<br />
                <asp:TextBox ID="TextBox19" runat="server" TextMode="MultiLine" Height="100px" Width="280px">Visual Studio 2017&nbsp;
Visual Studio Code&nbsp;
</asp:TextBox>
                <br />
                <br />
                Операційні системи<br />
                <asp:TextBox ID="TextBox20" runat="server" TextMode="MultiLine" Height="100px" Width="280px">Windows
Linux</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Languages">
                Іноземні мови та рівень володіння<br />
                <asp:TextBox ID="TextBox21" runat="server" Height="100px" Width="280px" TextMode="MultiLine">English, B2
German, A2</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Interests">
                Інтереси<br />
                <asp:TextBox ID="TextBox22" runat="server" Height="100px" TextMode="MultiLine" Width="280px">Cycling, trial, extreme sports, skydiving
</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Download Photos">
                <br />
                Посилання на фото<br />
                <asp:TextBox ID="TextBox32" runat="server" Width="280px">https://i.imgur.com/q8djgoV.jpg</asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="View Resume">
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
</asp:Content>
