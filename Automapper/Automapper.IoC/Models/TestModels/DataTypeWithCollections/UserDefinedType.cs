﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.TestModels.DataTypeWithCollections
{
    public class UserDefinedType
    {
        public string Property1 { get; set; }
        [IgnoreDataMember]
        public string Property2 { get; set; }

        public static UserDefinedType GetInstance()
        {
            return new UserDefinedType
            {
                Property1 = $"{nameof(UserDefinedType)}:{nameof(UserDefinedType.Property1)}",
                Property2 = $"{nameof(UserDefinedType)}:{nameof(UserDefinedType.Property2)}"
            };
        }
    }
}
