import React from 'react'
import { useState } from 'react';
import './App3.css';
import { Header } from './components/Header';
import TaskList from './components/TaskList';
import { AddTask } from './components/AddTask';
export default function App3() {

    const [tasks, setTasks] = useState([
    {id: 5271, name: "Record React Lectures", completed: true},
    {id: 7825, name: "Edit React Lectures", completed: false},
    {id: 8391, name: "Watch Lectures", completed: false}
    ]);
    
   
  return (
      <div className="App">
      <Header />
      <AddTask tasks={tasks} setTasks={setTasks}/>
       <TaskList title="Random" subtitle="Test" tasks={tasks} setTasks={setTasks} />
          
   </div>
  )
}


