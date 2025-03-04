import React from 'react';
import ReactDOM from 'react-dom/client';
import "./CSS/style.css";
import { Header } from './Layouts/Header';
import Footer from './Layouts/Footer';
import  Students  from './students/Students';
import { MainBody } from './Layouts/MainBody';
import { StudentReview } from './students/StudentReview';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <div>

    <Header/>
    <MainBody variable1="taskopedia" count={3}   />
    <Students fullName="radhakumari" programmingExp={4} headspot="https://randomuser.me/api/portraits/women/40.jpg">
    <StudentReview/>
    </Students>
    
    <Students  fullName="rajeshkumar" programmingExp={3}  headspot="https://randomuser.me/api/portraits/men/40.jpg"  />
    <Students  fullName="sanjaana" programmingExp={2}  headspot="https://randomuser.me/api/portraits/women/90.jpg"/>
    <Footer></Footer>
  
</div>
);
