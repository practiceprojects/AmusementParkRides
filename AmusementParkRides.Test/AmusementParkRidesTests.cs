using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkRides.Test
{
    [TestFixture]
    class AmusementParkRidesTests
    {
        [Test]
        public void CTOR__create()
        {
            var APR = new Rides();
            var result = APR.GetName = "Cyclone";
            Assert.That(result, Is.EqualTo("Cyclone"));
        }

        [Test]
        public void CTOR_create_derived()
        {
            var APR = new Coasters();
            var result = APR.GetName = "Cyclone";
            Assert.That(result, Is.EqualTo("Cyclone"));
        }

        [Test]
        public void CTOR_material_prop()
        {
            var APR = new Rides();
            var result = APR.GetMaterial = "Steel";
            Assert.That(result, Is.EqualTo("Steel"));
        }

        [Test]
        public void Method_Get_Number_of_Riders_if_Steel_Coaster()
        {
            var Coast = new Coasters();
            var result = Coast.GetNumRiders("Steel");
            Assert.That(result, Is.EqualTo("5"));
        }

        [Test]
        public void Method_Get_Number_of_Riders_if_Wood_Coaster()
        {
            var Coast = new Coasters();
            var result = Coast.GetNumRiders("wood");
            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Method_Get_Number_of_Riders_if_Alum_Coaster()
        {
            var Coast = new Coasters();
            var result = Coast.GetNumRiders("alum");
            Assert.That(result, Is.EqualTo("4"));
        }

        [Test]
        public void Method_Get_Number_of_Riders_if_Material_Not_Approved_Equals_0()
        {
            var Coast = new Coasters();
            var result = Coast.GetNumRiders("paper");
            Assert.That(result, Is.EqualTo("0"));
        }
    }
}
