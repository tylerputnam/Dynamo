using System;
using System.Collections.Generic;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoCore.Lang;
namespace ProtoTest
{
    [TestFixture]
    public class ModifierStackTests
    {
        private ProtoCore.Core core;
        [SetUp]
        public void Setup()
        {
            core = new ProtoCore.Core(new ProtoCore.Options());
            core.Options.ExecutionMode = ProtoCore.ExecutionMode.Serial;
            core.Executives.Add(ProtoCore.Language.kAssociative, new ProtoAssociative.Executive(core));
            core.Executives.Add(ProtoCore.Language.kImperative, new ProtoImperative.Executive(core));
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
        }
        [Test]
        public void SimpleExpr()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
                        @"
        }
        [Test]
        public void SimpleFuncDef()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
                        @"
        }
        [Test]
        public void SimpleExprInModifierStack()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"
            Assert.IsTrue((Int64)mirror.GetValue("a", 0).Payload == 10);

        }
        [Test]
        public void TwoSimpleExprInModifierStack()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"
            Assert.IsTrue((Int64)mirror.GetValue("a", 0).Payload == 20);
        }
        [Test]
        public void TwoExprInModifierStackWithOp()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"
            Assert.IsTrue((Int64)mirror.GetValue("a", 0).Payload == 60);
        }


        [Test]
        public void ModifierStackWithName()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"
            Assert.IsTrue((Int64)mirror.GetValue("a@init", 0).Payload == 2);
            Assert.IsTrue((Int64)mirror.GetValue("a", 0).Payload == 6);
        }
        [Test]
        public void ModifierStackWithTwoNames()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"
            Assert.IsTrue((Int64)mirror.GetValue("a@init", 0).Payload == 3);
            Assert.IsTrue((Int64)mirror.GetValue("a@first", 0).Payload == 4);
            Assert.IsTrue((Int64)mirror.GetValue("a", 0).Payload == 16);
        }
        [Test]
        public void ModifierStackWithArray()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"

            Obj o = mirror.GetValue("a@init");
            List<Obj> os = mirror.GetArrayElements(o);
            Assert.IsTrue(os.Count == 3);
            Assert.IsTrue((Int64)os[0].Payload == 3);
            Assert.IsTrue((Int64)os[1].Payload == 2);
            Assert.IsTrue((Int64)os[2].Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("a@first", 0).Payload == 1);
        }
        [Test]
        public void ModifierStackWithArrayAndFunction()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"a@init;a@first;b;
            Obj o = mirror.GetValue("a@init");
            List<Obj> os = mirror.GetArrayElements(o);
            Assert.IsTrue(os.Count == 3);
            Assert.IsTrue((Int64)os[0].Payload == 3);
            Assert.IsTrue((Int64)os[1].Payload == 2);
            Assert.IsTrue((Int64)os[2].Payload == 1);
            Assert.IsTrue((Int64)mirror.GetValue("a@first", 0).Payload == 9);
            Assert.IsTrue((Int64)mirror.GetValue("b", 0).Payload == 9);
        }

        [Test]
        public void ModifierStackWithArrayAndFunction2()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"b;a@init;a@first;
            Assert.IsTrue((Int64)mirror.GetValue("a@init", 0).Payload == 8);
            Assert.IsTrue((Int64)mirror.GetValue("a@first", 0).Payload == 10);
            Assert.IsTrue((Int64)mirror.GetValue("b", 0).Payload == 10);
        }
        [Test]
        public void ModifierStackWithArrayAndFunctionReplication()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            ExecutionMirror mirror = fsr.Execute(
                        @"a@init;a@first;b;
            Obj o = mirror.GetValue("a@init");
            List<Obj> os = mirror.GetArrayElements(o);
            Assert.IsTrue(os.Count == 3);
            Assert.IsTrue((Int64)os[0].Payload == 1);
            Assert.IsTrue((Int64)os[1].Payload == 2);
            Assert.IsTrue((Int64)os[2].Payload == 3);
            o = mirror.GetValue("a@first");
            os = mirror.GetArrayElements(o);
            Assert.IsTrue(os.Count == 3);
            Assert.IsTrue((Int64)os[0].Payload == 3);
            Assert.IsTrue((Int64)os[1].Payload == 4);
            Assert.IsTrue((Int64)os[2].Payload == 5);
            o = mirror.GetValue("b");
            os = mirror.GetArrayElements(o);
            Assert.IsTrue(os.Count == 3);
            Assert.IsTrue((Int64)os[0].Payload == 3);
            Assert.IsTrue((Int64)os[1].Payload == 4);
            Assert.IsTrue((Int64)os[2].Payload == 5);
        }
        [Test]
        public void ClassTest()
        {
            ProtoScript.Runners.ProtoScriptTestRunner fsr = new ProtoScript.Runners.ProtoScriptTestRunner();
            fsr.Execute(
                       @"
            //Object o = mirror.GetValue("point.mx");
            //Assert.IsTrue((long)o == 10);
        }
    }
}