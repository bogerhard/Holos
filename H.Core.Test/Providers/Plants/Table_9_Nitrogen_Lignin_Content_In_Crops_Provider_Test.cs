﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using H.Core.Providers.Plants;
using H.Core.Enumerations;

namespace H.Core.Test.Providers.Plants
{
    [TestClass]
    public class Table_9_Nitrogen_Lignin_Content_In_Crops_Provider_Test
    {
        #region Fields
        private static Table_9_Nitrogen_Lignin_Content_In_Crops_Provider _provider;
        #endregion

        #region Initialization
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _provider = new Table_9_Nitrogen_Lignin_Content_In_Crops_Provider();
        }

        [ClassCleanup]
        public static void ClassCleanup() { }

        [TestInitialize]
        public void TestInitialize() { }

        [TestCleanup]
        public void TestCleanup() { }

        #endregion

        #region Tests
        [TestMethod]
        public void GetContentsInstance()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.NFixingForages);
            Assert.AreEqual(0.025, data.NitrogenContentResidues);
        }

        [TestMethod]
        public void GetInstanceWrongCrop()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.KabuliChickpea);
            Assert.AreEqual(0, data.LigninContentResidues);
        }

        [TestMethod]
        public void CheckMoistureContent()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.SugarBeets);
            Assert.AreEqual(80.0, data.MoistureContent);
        }

        [TestMethod]
        public void CheckLigninContentOfResidues()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.OtherDryFieldBeans);
            Assert.AreEqual(0.075, data.LigninContentResidues);
        }

        [TestMethod]
        public void CheckRootToShootRatioOfCrop()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.Rice);
            Assert.AreEqual(0.0, data.RSTRatio);
        }

        [TestMethod]
        public void CheckSlopeValueOfCrop()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.Grains);
            Assert.AreEqual(0.02, data.SlopeValue);
        }

        [TestMethod]
        public void CheckInterceptValueOfCrop()
        {
            Table_9_Nitrogen_Lignin_Content_In_Crops_Data data = _provider.GetDataByCropType(CropType.WhiteBeans);
            Assert.AreEqual(0.279, data.InterceptValue);
        }
        #endregion
    }
}
