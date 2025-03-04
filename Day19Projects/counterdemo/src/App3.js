import React from 'react'

import './App3.css';
import { Header } from './components/Header';
import TaskList from './components/TaskList';
export default function App3() {

    
    
   
  return (
      <div className="App">
          <Header/>
       <TaskList title="Random" subtitle="Test" />
          
   </div>
  )
}


