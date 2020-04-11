﻿using NUnit.Framework;
using Automapper._3.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Resources;

namespace Automapper._3.IoC.Tests
{
    [TestFixture()]
    public class ValueMapperTests
    {
        private Func<Type, string, object> _iocInstance;
        [SetUp]
        public void SetupTest()
        {
            _iocInstance = Caliburn.Micro.IoC.GetInstance;
            Caliburn.Micro.IoC.GetInstance = (type, _) =>
            {
                if (type == typeof(Shared.TestModels.DataTypeWithCollections.Destination))
                {
                    return Shared.TestModels.DataTypeWithCollections.Destination.GetInstanceForIoC();
                }

                if (type == typeof(Shared.TestModels.DataTypeWithCollections.UserDefinedType))
                {
                    return Shared.TestModels.DataTypeWithCollections.UserDefinedType.GetInstanceForIoC();
                }
                return null;
            };
        }
        [TearDown]
        public void Cleanup()
        {
            Caliburn.Micro.IoC.GetInstance = _iocInstance;
        }
        [Test]
        public void MapperDataTypeWithCollections()
        {
            var sharedValueMapperTests = new Shared.TestCases.ValueMapperTests();
            sharedValueMapperTests.MapperDataTypeWithCollections(new ValueMapper());
        }
    }
}