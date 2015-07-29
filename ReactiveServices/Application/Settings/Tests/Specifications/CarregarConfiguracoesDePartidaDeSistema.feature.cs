﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ReactiveServices.Application.Settings.Tests.Specifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Carregar configuracoes de partida de sistema")]
    public partial class CarregarConfiguracoesDePartidaDeSistemaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CarregarConfiguracoesDePartidaDeSistema.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Carregar configuracoes de partida de sistema", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Carregar configuração para uma única execução de uma solicitação de trabalhos do " +
            "tipo A, em um único despachante de trabalhos")]
        [NUnit.Framework.CategoryAttribute("stable")]
        [NUnit.Framework.CategoryAttribute("fast")]
        public virtual void CarregarConfiguracaoParaUmaUnicaExecucaoDeUmaSolicitacaoDeTrabalhosDoTipoAEmUmUnicoDespachanteDeTrabalhos()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Carregar configuração para uma única execução de uma solicitação de trabalhos do " +
                    "tipo A, em um único despachante de trabalhos", new string[] {
                        "stable",
                        "fast"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("que as configurações solicitem a execução de uma instância do despachante de trab" +
                    "alhos a ser identificada como despachante \'SettingsTest1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.And("que as configurações informem que o despachante \'SettingsTest1\' será capaz de pro" +
                    "cessar até 1 solicitações de trabalho por vez", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 9
 testRunner.And("que as configurações informem que o despachante \'SettingsTest1\' será capaz de pro" +
                    "cessar solicitações de trabalho do tipo \'A\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("que as configurações solicitem a execução de 1 solicitações de trabalho do tipo \'" +
                    "A\' na partida do sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.When("as configurações forem carregadas no gerenciador de partida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 12
 testRunner.Then("o gerenciador de partida deve solicitar a execução de uma instância do despachant" +
                    "e de trabalhos a ser identificada como despachante \'SettingsTest1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 13
 testRunner.And("o despachante \'SettingsTest1\' deve ser capaz de processar até 1 solicitações de t" +
                    "rabalho por vez", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("o despachante \'SettingsTest1\' deve ser capaz de processar solicitações de trabalh" +
                    "o do tipo \'A\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.And("o gerenciador de partida deve solicitar a execução de 1 solicitações de trabalho " +
                    "do tipo \'A\' na partida do sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A," +
            " em um único despachante de trabalhos")]
        [NUnit.Framework.CategoryAttribute("stable")]
        [NUnit.Framework.CategoryAttribute("fast")]
        [NUnit.Framework.TestCaseAttribute("2", null)]
        [NUnit.Framework.TestCaseAttribute("10", null)]
        [NUnit.Framework.TestCaseAttribute("20", null)]
        public virtual void CarregarConfiguracaoParaNExecucoesDeUmaSolicitacaoDeTrabalhosDoTipoAEmUmUnicoDespachanteDeTrabalhos(string n, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "stable",
                    "fast"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A," +
                    " em um único despachante de trabalhos", @__tags);
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given(string.Format("que as configurações solicitem a execução de uma instância do despachante de trab" +
                        "alhos a ser identificada como despachante \'SettingsTest2_{0}\'", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 20
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest2_{0}\' será capaz de" +
                        " processar até {0} solicitações de trabalho por vez", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 21
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest2_{0}\' será capaz de" +
                        " processar solicitações de trabalho do tipo \'A\'", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 22
 testRunner.And(string.Format("que as configurações solicitem a execução de {0} solicitações de trabalho do tipo" +
                        " \'A\' na partida do sistema", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
 testRunner.When("as configurações forem carregadas no gerenciador de partida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
 testRunner.Then(string.Format("o gerenciador de partida deve solicitar a execução de uma instância do despachant" +
                        "e de trabalhos a ser identificada como despachante \'SettingsTest2_{0}\'", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 25
 testRunner.And(string.Format("o despachante \'SettingsTest2_{0}\' deve ser capaz de processar até {0} solicitaçõe" +
                        "s de trabalho por vez", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.And(string.Format("o despachante \'SettingsTest2_{0}\' deve ser capaz de processar solicitações de tra" +
                        "balho do tipo \'A\'", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
 testRunner.And(string.Format("o gerenciador de partida deve solicitar a execução de {0} solicitações de trabalh" +
                        "o do tipo \'A\' na partida do sistema", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A," +
            " em dois despachantes de trabalhos")]
        [NUnit.Framework.CategoryAttribute("stable")]
        [NUnit.Framework.CategoryAttribute("fast")]
        [NUnit.Framework.TestCaseAttribute("2", "1", "1", null)]
        [NUnit.Framework.TestCaseAttribute("11", "6", "5", null)]
        [NUnit.Framework.TestCaseAttribute("20", "10", "10", null)]
        public virtual void CarregarConfiguracaoParaNExecucoesDeUmaSolicitacaoDeTrabalhosDoTipoAEmDoisDespachantesDeTrabalhos(string n, string m, string o, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "stable",
                    "fast"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A," +
                    " em dois despachantes de trabalhos", @__tags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given(string.Format("que as configurações solicitem a execução de uma instância do despachante de trab" +
                        "alhos a ser identificada como despachante \'SettingsTest3_Tipo1_{0}{1}{2}\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
 testRunner.And(string.Format("que as configurações solicitem a execução de uma instância do despachante de trab" +
                        "alhos a ser identificada como despachante \'SettingsTest3_Tipo2_{0}{1}{2}\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 38
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo1_{0}{1}{2}\' s" +
                        "erá capaz de processar até {1} solicitações de trabalho por vez", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 39
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo1_{0}{1}{2}\' s" +
                        "erá capaz de processar solicitações de trabalho do tipo \'A\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 40
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo2_{0}{1}{2}\' s" +
                        "erá capaz de processar até {2} solicitações de trabalho por vez", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 41
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo2_{0}{1}{2}\' s" +
                        "erá capaz de processar solicitações de trabalho do tipo \'A\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 42
 testRunner.And(string.Format("que as configurações solicitem a execução de {0} solicitações de trabalho do tipo" +
                        " \'A\' na partida do sistema", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 43
 testRunner.When("as configurações forem carregadas no gerenciador de partida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 44
 testRunner.Then(string.Format("o gerenciador de partida deve solicitar a execução de uma instância do despachant" +
                        "e de trabalhos a ser identificada como despachante \'SettingsTest3_Tipo1_{0}{1}{2" +
                        "}\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 45
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo1_{0}{1}{2}\' deve ser capaz de processar até {1}" +
                        " solicitações de trabalho por vez", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 46
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo1_{0}{1}{2}\' deve ser capaz de processar solicit" +
                        "ações de trabalho do tipo \'A\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 47
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo2_{0}{1}{2}\' deve ser capaz de processar até {2}" +
                        " solicitações de trabalho por vez", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 48
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo2_{0}{1}{2}\' deve ser capaz de processar solicit" +
                        "ações de trabalho do tipo \'A\'", n, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 49
 testRunner.And(string.Format("o gerenciador de partida deve solicitar a execução de {0} solicitações de trabalh" +
                        "o do tipo \'A\' na partida do sistema", n), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A " +
            "e outra do tipo B, em dois despachantes de trabalhos")]
        [NUnit.Framework.CategoryAttribute("stable")]
        [NUnit.Framework.CategoryAttribute("fast")]
        [NUnit.Framework.TestCaseAttribute("2", "2", "2", "2", null)]
        [NUnit.Framework.TestCaseAttribute("11", "11", "11", "11", null)]
        [NUnit.Framework.TestCaseAttribute("20", "20", "20", "20", null)]
        public virtual void CarregarConfiguracaoParaNExecucoesDeUmaSolicitacaoDeTrabalhosDoTipoAEOutraDoTipoBEmDoisDespachantesDeTrabalhos(string n1, string n2, string m, string o, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "stable",
                    "fast"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Carregar configuração para n execuções de uma solicitação de trabalhos do tipo A " +
                    "e outra do tipo B, em dois despachantes de trabalhos", @__tags);
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
 testRunner.Given(string.Format("que as configurações solicitem a execução de uma instância do despachante de trab" +
                        "alhos a ser identificada como despachante \'SettingsTest3_Tipo1_{0}{1}{2}{3}\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.And(string.Format("que as configurações solicitem a execução de uma instância do despachante de trab" +
                        "alhos a ser identificada como despachante \'SettingsTest3_Tipo2_{0}{1}{2}{3}\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 60
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo1_{0}{1}{2}{3}" +
                        "\' será capaz de processar até {2} solicitações de trabalho por vez", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 61
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo1_{0}{1}{2}{3}" +
                        "\' será capaz de processar solicitações de trabalho do tipo \'A\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 62
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo2_{0}{1}{2}{3}" +
                        "\' será capaz de processar até {3} solicitações de trabalho por vez", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 63
 testRunner.And(string.Format("que as configurações informem que o despachante \'SettingsTest3_Tipo2_{0}{1}{2}{3}" +
                        "\' será capaz de processar solicitações de trabalho do tipo \'B\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 64
 testRunner.And(string.Format("que as configurações solicitem a execução de {0} solicitações de trabalho do tipo" +
                        " \'A\' na partida do sistema", n1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 65
 testRunner.And(string.Format("que as configurações solicitem a execução de {0} solicitações de trabalho do tipo" +
                        " \'B\' na partida do sistema", n2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 66
 testRunner.When("as configurações forem carregadas no gerenciador de partida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 67
 testRunner.Then(string.Format("o gerenciador de partida deve solicitar a execução de uma instância do despachant" +
                        "e de trabalhos a ser identificada como despachante \'SettingsTest3_Tipo1_{0}{1}{2" +
                        "}{3}\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 68
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo1_{0}{1}{2}{3}\' deve ser capaz de processar até " +
                        "{2} solicitações de trabalho por vez", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 69
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo1_{0}{1}{2}{3}\' deve ser capaz de processar soli" +
                        "citações de trabalho do tipo \'A\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 70
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo2_{0}{1}{2}{3}\' deve ser capaz de processar até " +
                        "{3} solicitações de trabalho por vez", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 71
 testRunner.And(string.Format("o despachante \'SettingsTest3_Tipo2_{0}{1}{2}{3}\' deve ser capaz de processar soli" +
                        "citações de trabalho do tipo \'B\'", n1, n2, m, o), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 72
 testRunner.And(string.Format("o gerenciador de partida deve solicitar a execução de {0} solicitações de trabalh" +
                        "o do tipo \'A\' na partida do sistema", n1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 73
 testRunner.And(string.Format("o gerenciador de partida deve solicitar a execução de {0} solicitações de trabalh" +
                        "o do tipo \'B\' na partida do sistema", n2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Salvar configurações em script e carregá-las no gerenciador de partida")]
        [NUnit.Framework.CategoryAttribute("stable")]
        [NUnit.Framework.CategoryAttribute("fast")]
        public virtual void SalvarConfiguracoesEmScriptECarrega_LasNoGerenciadorDePartida()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Salvar configurações em script e carregá-las no gerenciador de partida", new string[] {
                        "stable",
                        "fast"});
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
 testRunner.Given("que as configurações solicitem a execução de uma instância do despachante de trab" +
                    "alhos a ser identificada como despachante \'SettingsTest5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 83
 testRunner.And("que as configurações informem que o despachante \'SettingsTest5\' será capaz de pro" +
                    "cessar até 1 solicitações de trabalho por vez", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 84
 testRunner.And("que as configurações informem que o despachante \'SettingsTest5\' será capaz de pro" +
                    "cessar solicitações de trabalho do tipo \'A\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 85
 testRunner.And("que as configurações solicitem a execução de 1 solicitações de trabalho do tipo \'" +
                    "A\' na partida do sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 86
 testRunner.When("as configurações forem salvas em um arquivo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 87
 testRunner.And("o arquivo for carregado nas configurações do gerenciador de partida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 88
 testRunner.Then("o gerenciador de partida deve solicitar a execução de uma instância do despachant" +
                    "e de trabalhos a ser identificada como despachante \'SettingsTest5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 89
 testRunner.And("o despachante \'SettingsTest5\' deve ser capaz de processar até 1 solicitações de t" +
                    "rabalho por vez", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 90
 testRunner.And("o despachante \'SettingsTest5\' deve ser capaz de processar solicitações de trabalh" +
                    "o do tipo \'A\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 91
 testRunner.And("o gerenciador de partida deve solicitar a execução de 1 solicitações de trabalho " +
                    "do tipo \'A\' na partida do sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
