using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using System.Collections.Generic;
using ProtoTestFx.TD;
namespace ProtoTest.TD.DocTests
{
    public class UserManualTests
    {
        readonly TestFrameWork thisTest = new TestFrameWork();
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void UM01_Print()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM02_Point()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("a", 10.0);
            thisTest.Verify("b", 2.5);
            thisTest.Verify("c", -6.0);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM03_Point()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM04_Line()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM05_SurfaceLoft()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM06_SurfaceThicken()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM07_SolidPlaneIntersect()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM08_CoordinateSystem()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM09_PointOnCylinderShere()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM10_Line()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM11_Solids()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM11_LineColor()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM12_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM13_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM14_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM15_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM16_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM17_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM18_Vector()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM19_Range()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 4);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM20_RangeLine()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM21_Range()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 0.5);
            thisTest.Verify("y", 0.7);
        }

        [Test]
        public void UM22_Range()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2.25);
            thisTest.Verify("y", 3.75);
        }

        [Test]
        public void UM23_Range()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 2.3333333333333335);
            thisTest.Verify("y", 3.8888888888888893);
        }

        [Test]
        public void UM24_Range()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 5.25);
            thisTest.Verify("y", 7.0);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM25_Collection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM26_Collection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM27_Collection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 100);
            thisTest.Verify("y", 3);
        }

        [Test]
        public void UM28_Collection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 67);
            thisTest.Verify("y", 67);
        }

        [Test]
        public void UM29_Collection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 10);
            thisTest.Verify("y", 12);
        }

        [Test]
        public void UM30_NumberTypes()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM31_NumberTypes()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("f1", 1.0);
            thisTest.Verify("f2", 1.0);
        }

        [Test]
        public void UM32_NumberTypes()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("pass_value", 2);
            thisTest.Verify("value", 2);
        }

        [Test]
        public void UM33_NumberTypes()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1);
        }

        [Test]
        public void UM34_NumberTypes()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 0);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM35_Associativity()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM36_Associativity()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM37_Functions()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM38_Functions()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("times_two", 20);
        }

        [Test]
        public void UM39_Functions()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("gr", 1.618034);
        }

        [Test]
        public void UM40_Functions()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1);
            thisTest.Verify("y", 2);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM41_Functions()
        {
            string code =
@"
            string str = "DNL-1467479 Regression : NullReferenceException when dot operator is called using replication for some typical classes ( cuboid )";
            thisTest.VerifyRunScriptSource(code, str);
        }

        [Test]
        public void UM42_Math()
        {
            string code =
@"

            thisTest.RunScriptSource(code);
            thisTest.Verify("f", 0);
            thisTest.Verify("c", 1);
            thisTest.Verify("r", 0.0);
            thisTest.Verify("r2", 1.0);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM43_Math()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM44_Math()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 1);
            thisTest.Verify("y", 5);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM45_Curves()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM46_Curves()
        {
            string code =
@"
            string str = "DNL-1467479 Regression : NullReferenceException when dot operator is called using replication for some typical classes ( cuboid )";
            thisTest.VerifyRunScriptSource(code, str);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM47_Curves()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM48_Curves()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM49_Curves()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM50_Curves()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM51_IDE()
        {
            string code =
@"
            string str = "DNL-1467479 Regression : NullReferenceException when dot operator is called using replication for some typical classes ( cuboid )";
            thisTest.VerifyRunScriptSource(code, str);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM52_IDE()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM53_Translation()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM54_Transform()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM55_Scale()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM56_ShearedCS()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM57_Imperative()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM58_Associative()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM59_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM60_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM61_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM62_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("result", true);
        }

        [Test]
        public void UM63_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("result", false);
        }

        [Test]
        public void UM64_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("result", false);
        }

        [Test]
        public void UM65_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("result", true);
        }

        [Test]
        public void UM66_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("result", true);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM67_Boolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM68_Looping()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM69_Looping()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM70_Replication()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM71_Replication()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM72_Replication()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM73_Replication()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM74_ModifierStack()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM75_JaggedCollection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 3);
            thisTest.Verify("y", 8);

        }

        [Test]
        public void UM76_JaggedCollectionFAIL()
        {
            ////the following test case is supposed to fail
            //                        string code =
            //@"
            //j = {1, {2, 3, 4}, 5, {{6, 7}, {{8}}}, 9};
            //j_sum = [Imperative]
            //{
            //sum = 0;
            //for (i in 0..(Count(j) – 1))
            //{
            //// access the ""i""th element of j,
            //// and add it to sum
            //sum = sum + j[i];
            //}
            //return = sum;
            //}
            //s = Print(j_sum);
            //            ";
            //                        thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM77_JaggedCollection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
            thisTest.Verify("x", 4);
            thisTest.Verify("y", 8);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM78_Surface()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM79_Surface()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM80_Surface()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM81_Surface()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM82_Surface()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        public void UM83_Parameterization()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM84_Parameterization()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM85_Intersection()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM86_Trim()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM87_SelectTrim()
        {
            string code =
@"
            string str = "DNL-1467479 Regression : NullReferenceException when dot operator is called using replication for some typical classes ( cuboid )";
            thisTest.VerifyRunScriptSource(code, str);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM88_GeometricBoolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM89_GeometricBoolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM90_GeometricBoolean()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM91_NonManifoldSolid()
        {
            string code =
@"
            thisTest.RunScriptSource(code);
        }

        [Test]
        [Category("ProtoGeometry")] [Ignore] [Category("PortToCodeBlocks")]
        public void UM92_NonManifoldSolid()
        {
            string code =
@"
            string str = "DNL-1467479 Regression : NullReferenceException when dot operator is called using replication for some typical classes ( cuboid )";
            thisTest.VerifyRunScriptSource(code, str);
        }
    }
}