using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FizzBuzz_Should_Return_1_Given_1()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(1);
            string expect = "1";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FizzBuzz_Should_Return_2_Given_2()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(2);
            string expect = "2";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FizzBuzz_Should_Return_Fizz_Given_3()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(3);
            string expect = "Fizz";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FizzBuzz_Should_Return_Buzz_Given_5()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(5);
            string expect = "Buzz";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FizzBuzz_Should_Return_Whizz_Given_7()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(7);
            string expect = "Whizz";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FizzBuzz_Should_Return_FizzBuzz_Given_15()
        {
            //given
            //Dependency dependency = new Dependency();
            //HelloWorld helloWorld = new HelloWorld(dependency);
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            //when
            string actual = fizzBuzz.Say(15);
            string expect = "FizzBuzz";
            //then
            //Assert.Equal("Leave me alone.", actual);
            Assert.Equal(expect, actual);
        }

        //[Fact]
        //public void Should_be_mocked()
        //{
        //    //given
        //    var mockDependencu = new Mock<Dependency>();
        //    mockDependencu.Setup(m => m.Say()).Returns("Hello World");
        //    HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

        //    //when
        //    string actual = helloWorld.BeenCalled();

        //    //then
        //    Assert.Equal("Hello World", actual);
        //}
    }
}