# QSEC_ImageLib

The best image library since sliced bread.  
The design ideas behind this library is 

- easy to use, compile and contribute to
- Easy to reference and use from other projects

With the QSEC_ImageLib you can 
- ImageInfo.GetPixels(Image image)
- ImageInfo.GetPixelsFromFile(string FileName)

## Prerequisites

1. Visual Studio 2017
2. .NET Framework 4.6.1

## Contribute to the fabulous QSEC_Library

If you would like to contribute to the project

1. **Fork** the project by pressing the the Fork button at https://github.com/TessFerrandez/QSEC_ImageFramework
2. **Clone** the forked project to your machine
3. Pick a **task** from the new column in https://github.com/TessFerrandez/QSEC_ImageFramework/projects/1 assign it to yourself and move it to **ongoing** to indicate that you are working on it.
4. Commit the work to your forked repository regularly
5. When you have completed a task. Create a **pull request** to merk the work into the main repository. At the same time, move the task on the project board to the PR column.

This is how you can create a PR: https://help.github.com/desktop/guides/contributing-to-projects/creating-a-pull-request/

## Coding standards

To make sure the code is testable, we use Interfaces

## Unit Tests

We use XUnit for testing.  

1. Place all the code for a given class in its own separate directory. e.g. tests for the ImageInfo class should be placed in the ImageInfoTests folder.
2. Tests should at least cover all acceptance criteria, but you are welcome to test more
3. Naming standard **FunctionTested_TestCondition_ExcpectedResult()**

Below are two example tests:

        [Fact]
        public void GetTotal_NoProducts_ReturnsPrice0()
        {
            //arrange
            var checkout = new Checkout();

            //act
            decimal priceResult = checkout.GetTotal();

            //assert
            Assert.Equal(0, priceResult);
        }

        [Fact]
        public void Scan_null_ThrowsArgumentNullException()
        {
            //arrange
            var checkout = new Checkout();

            //act and assert
            Assert.Throws<ArgumentNullException>(() => checkout.Scan(null));
        }


