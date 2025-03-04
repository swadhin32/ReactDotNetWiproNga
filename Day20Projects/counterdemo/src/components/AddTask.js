import React from 'react'
import "./AddTask.css";
import { useState ,useRef} from 'react';

export const AddTask = ({tasks,setTasks}) => {

 //   const [taskValue, setTaskValue] = useState("");
    const [progress, setProgress] = useState(false);
    const taskRef = useRef("");

    // const handleChange = (event) =>
    // {

    //    setTaskValue(event.target.value)
    // }

    const handleReset = () =>
    {
        // setTaskValue("");
        taskRef.current.value = "";
    }

    const handleDropdown = (event) =>
    {
        setProgress(event.target.value);
    }
    const handleSubmit = (event) =>
    {
        event.preventDefault();
        const task =
        {
            id : Math.floor(Math.random() * 10000),
                name :taskRef.current.value,
                completed:Boolean(progress)
        }
      // console.log(task);
//setTasks(task) // this will give error as it is list so chnaged like this below
//setTasks([task])// this will override earlier 3 tasks so finally i will write this we have to follow this rule
        setTasks([...tasks,task])
        handleReset();
    }

    return (
      
        <section className="addtask">

            <form onSubmit={handleSubmit}>
                
                <input type="text"  name="task" id="task" placeholder='enter task name' autoComplete="off" 
                    ref={taskRef} />
                <select onChange={handleDropdown} value={progress}>
                    <option value="false">Pending</option>
                    <option value="true">Completed</option>
               </select>
                        <button type="submit" style={{ background: "blue" }}>Add task</button><br/>
             
                <button onClick={handleReset} className='reset' style={{ background: "blue",color:"white" }} >Reset</button>
          </form>
          <p> {taskRef.current.value}</p>
        </section>
   
  )
}
