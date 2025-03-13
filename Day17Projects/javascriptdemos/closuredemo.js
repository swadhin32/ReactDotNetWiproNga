function counterFunction()
{
    let count = 0;//private variable

     function increment () //closure function will not return now as given name
    {
        count = count + 1;
        console.log("Current count:", count);
        
    }
    increment();// when not retrnign give it a call like this 
}

counterFunction();
counterFunction();