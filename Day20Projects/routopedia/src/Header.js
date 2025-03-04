
import React from 'react';
import { Link } from "react-router-dom";

export const Header = () => {
  return (
    <nav className="navbar navbar-expand-lg bg-light">
      <div className="container-fluid">
        <a className="navbar-brand" href="#">Navbar scroll</a>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarScroll"
          aria-controls="navbarScroll"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarScroll">
          <ul
            className="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll"
            style={{ '--bs-scroll-height': '100px' }} // ✅ React style syntax
          >
            <li className="nav-item">
              <Link className="nav-link" to="/">
                Home
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/aboutus">
                Aboutus
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/cryptography">
                Cryptogrpahy
              </Link>
            </li>
            <li className="nav-item dropdown">
              <a
                className="nav-link dropdown-toggle"
                href="#"
                role="button"
                data-bs-toggle="dropdown"
                aria-expanded="false"
              >
              products
              </a>
              <ul className="dropdown-menu">
                <li>
                  <Link className="nav-link" to="/products/create">
                   Createproduct
                  </Link>

                </li>
                <li>
                  <Link className="nav-link" to="/products/list">
                  ProductList
               </Link>
                </li>
                <li>
                  <Link className="nav-link" to="/products/display">
                    Producdisplay
                  </Link>
                </li>

              
              </ul>
            </li>
            <li className="nav-item">
              <a className="nav-link disabled">Link</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};




