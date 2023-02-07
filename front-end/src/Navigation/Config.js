import { createBrowserRouter, Route, Navigate } from "react-router-dom";
import { Layout } from "../Layout/Layout";
import Home from "../Pages/Home/Home";
import Login from "../Pages/Login/Login";
import Register from "../Pages/Register/Register";
import { ROOT, LOGIN, REGISTER } from './Paths'

const auth = true

const ProtectedRoutes = ({children}) => {
    if (!auth ) {
        return <Navigate to='/login' />
    }
    return children
}


export const RouterConfig = createBrowserRouter([
    {
        path: ROOT,
        element: <ProtectedRoutes><Layout /></ProtectedRoutes>,
        children: [
            {
                path:ROOT,
                element: <Home />
            }
        ]
    },{
        path: LOGIN,
        element: <Login/>
    },{
        path: REGISTER,
        element: <Register/>
    }
])