﻿using Ivanov_Leonid_KT_44_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanov_Leonid_KT_44_21.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT4421_True()
        {
            //arrange
            var testGroup = new Group
            {
                GroupName = "KT-44-21"
            };

            //act
            var result = testGroup.IsValidGroupName();

            //assert
            Assert.True(result);
        }
    }
}