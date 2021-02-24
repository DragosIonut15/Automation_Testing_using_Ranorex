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
    ///The Delete_data_from_student recording.
    /// </summary>
    [TestModule("9840a8fe-5658-4b35-971b-cc56123ceb1a", ModuleType.Recording, 1)]
    public partial class Delete_data_from_student : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Licenta_NohaiRepository repository.
        /// </summary>
        public static Licenta_NohaiRepository repo = Licenta_NohaiRepository.Instance;

        static Delete_data_from_student instance = new Delete_data_from_student();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Delete_data_from_student()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Delete_data_from_student Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContainerFluid.FaIcon' at Center.", repo.ApplicationUnderTest.ContainerFluid.FaIconInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ContainerFluid.FaIcon.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Ștergere' at Center.", repo.ApplicationUnderTest.ȘtergereInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Ștergere.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
