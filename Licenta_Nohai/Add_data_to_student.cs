﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Licenta_Nohai
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Add_data_to_student recording.
    /// </summary>
    [TestModule("e8f42997-8872-4a64-90b3-2e2994b983cb", ModuleType.Recording, 1)]
    public partial class Add_data_to_student : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Licenta_NohaiRepository repository.
        /// </summary>
        public static Licenta_NohaiRepository repo = Licenta_NohaiRepository.Instance;

        static Add_data_to_student instance = new Add_data_to_student();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_data_to_student()
        {
            NumeStudent = "asd";
            PrenumeStudent = "asd";
            NumarMatricol = "123123";
            LucrareLicenta = "asdasd";
            LiniaDePredare = "rom";
            ProfesorCoordonator = "silaghi";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_data_to_student Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumeStudent;

        /// <summary>
        /// Gets or sets the value of variable NumeStudent.
        /// </summary>
        [TestVariable("8dedc401-e706-41f6-9825-df349d51ab44")]
        public string NumeStudent
        {
            get { return _NumeStudent; }
            set { _NumeStudent = value; }
        }

        string _PrenumeStudent;

        /// <summary>
        /// Gets or sets the value of variable PrenumeStudent.
        /// </summary>
        [TestVariable("b9981339-ca26-4949-881c-957c38c15062")]
        public string PrenumeStudent
        {
            get { return _PrenumeStudent; }
            set { _PrenumeStudent = value; }
        }

        string _NumarMatricol;

        /// <summary>
        /// Gets or sets the value of variable NumarMatricol.
        /// </summary>
        [TestVariable("c074ca0b-b41e-4f72-8b25-038dcb99900e")]
        public string NumarMatricol
        {
            get { return _NumarMatricol; }
            set { _NumarMatricol = value; }
        }

        string _LucrareLicenta;

        /// <summary>
        /// Gets or sets the value of variable LucrareLicenta.
        /// </summary>
        [TestVariable("b07c2af1-f413-4014-ba83-e00bed9530a7")]
        public string LucrareLicenta
        {
            get { return _LucrareLicenta; }
            set { _LucrareLicenta = value; }
        }

        string _LiniaDePredare;

        /// <summary>
        /// Gets or sets the value of variable LiniaDePredare.
        /// </summary>
        [TestVariable("1829590e-0f4c-454d-a265-4471355f10c1")]
        public string LiniaDePredare
        {
            get { return _LiniaDePredare; }
            set { _LiniaDePredare = value; }
        }

        string _ProfesorCoordonator;

        /// <summary>
        /// Gets or sets the value of variable ProfesorCoordonator.
        /// </summary>
        [TestVariable("6efd600d-de83-4761-876b-a8b063c84ecf")]
        public string ProfesorCoordonator
        {
            get { return _ProfesorCoordonator; }
            set { _ProfesorCoordonator = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.JhCreateEntity' at Center.", repo.ApplicationUnderTest.JhCreateEntityInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.JhCreateEntity.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldNume' at Center.", repo.ApplicationUnderTest.FieldNumeInfo, new RecordItemIndex(1));
            //repo.ApplicationUnderTest.FieldNume.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeStudent' with focus on 'ApplicationUnderTest.FieldNume'.", repo.ApplicationUnderTest.FieldNumeInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.FieldNume.PressKeys(NumeStudent);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldPrenume' at Center.", repo.ApplicationUnderTest.FieldPrenumeInfo, new RecordItemIndex(3));
            //repo.ApplicationUnderTest.FieldPrenume.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PrenumeStudent' with focus on 'ApplicationUnderTest.FieldPrenume'.", repo.ApplicationUnderTest.FieldPrenumeInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.FieldPrenume.PressKeys(PrenumeStudent);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldNumarMatricol' at Center.", repo.ApplicationUnderTest.FieldNumarMatricolInfo, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.FieldNumarMatricol.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumarMatricol' with focus on 'ApplicationUnderTest.FieldNumarMatricol'.", repo.ApplicationUnderTest.FieldNumarMatricolInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.FieldNumarMatricol.PressKeys(NumarMatricol);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldLucrareLicenta' at Center.", repo.ApplicationUnderTest.FieldLucrareLicentaInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.FieldLucrareLicenta.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LucrareLicenta' with focus on 'ApplicationUnderTest.FieldLucrareLicenta'.", repo.ApplicationUnderTest.FieldLucrareLicentaInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.FieldLucrareLicenta.PressKeys(LucrareLicenta);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldLinia' at Center.", repo.ApplicationUnderTest.FieldLiniaInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.FieldLinia.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LiniaDePredare' with focus on 'ApplicationUnderTest.FieldLinia'.", repo.ApplicationUnderTest.FieldLiniaInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.FieldLinia.PressKeys(LiniaDePredare);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.FieldForma' at Center.", repo.ApplicationUnderTest.FieldFormaInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.FieldForma.MoveTo();
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.FieldForma' at Center.", repo.ApplicationUnderTest.FieldFormaInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.FieldForma.MoveTo();
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Dropdown' at Center.", repo.Dropdown.SelfInfo, new RecordItemIndex(14));
            repo.Dropdown.Self.MoveTo();
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Dropdown' at Center.", repo.Dropdown.SelfInfo, new RecordItemIndex(15));
            repo.Dropdown.Self.MoveTo();
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FieldCadruDidactic' at Center.", repo.ApplicationUnderTest.FieldCadruDidacticInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.FieldCadruDidactic.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ProfesorCoordonator' with focus on 'ApplicationUnderTest.FieldCadruDidactic'.", repo.ApplicationUnderTest.FieldCadruDidacticInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.FieldCadruDidactic.PressKeys(ProfesorCoordonator);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(18));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Salvare' at Center.", repo.ApplicationUnderTest.SalvareInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Salvare.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
