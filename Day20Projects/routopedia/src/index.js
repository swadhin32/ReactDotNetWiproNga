import React from "react";
import ReactDOM from "react-dom/client";
import { Header } from "./Header";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { CryptoGrpahy } from "./CryptoGrpahy";
import { AboutUs } from "./AboutUs";
import { Home } from "./Home";
import { NotFound } from "./NotFound"
import DisplayProduct from "./products/DisplayProduct";
import CreateProduct from "./products/CreateProduct";
import ProductList from "./products/ProductList";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <BrowserRouter>
      <Header />
      <Routes>
        <Route path="/" element={<Home />}></Route>
        <Route path="/aboutus" element={<AboutUs />}></Route>
        <Route path="/cryptography" element={<CryptoGrpahy />}></Route>


        <Route path="products">
          
          <Route path="display" element={<DisplayProduct />}></Route>
          <Route path="create" element={<CreateProduct />}></Route>
          <Route path="list" element={<ProductList />}></Route>
        </Route>







      
        <Route path="*" element={<NotFound />}></Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);