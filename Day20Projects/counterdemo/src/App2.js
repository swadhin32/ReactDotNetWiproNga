import React, { useState } from 'react'
import './App.css';

 const App2 = () => {

    const [counterState, setCounterState] = useState(() => { return { counter: 10, title2: "Fun" }; });

    const[titleState, setTitleSate] = useState("Fun");

    const[titleState1, setTitleSate1] = useState(()=>{return {  title1: "Fun" }; });


 function incrementCounter()
    {
    setCounterState((counterState) => { return { counter:counterState.counter + 1 }; });
    }
function decrementCounter()
    {
    setCounterState((prevState) => { return { counter: prevState.counter - 1 } });
    setCounterState((prevState)=>{ return {counter:prevState.counter -1} });
    }
return (
        <div className="col-12 col-md-4 offset-md-4 border text-white">
        <span className="h2 pt-4 m-2 text-white-50">{titleState}Counter </span><br/>
        <span className="h2 pt-4 m-2 text-white-50">{titleState1.title1} Counter </span><br/>
        <span className="h2 pt-4 m-2 text-white-50">{counterState.title2} Counter </span>
        <br />
        <button className="btn btn-success m-1" onClick={incrementCounter}>+1</button>
        <button className="btn btn-danger m-1" onClick={decrementCounter}>-1</button>
        <br />
        <span className="h4">
        Counter: &nbsp;
        <span className="text-success">{counterState.counter }</span>
        </span>
        </div>
)
}

export default App2;