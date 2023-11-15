import { Counter } from "./components/Counter";
import { Users } from "./components/Users";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
    },

    {
        path: '/users',
        element: <Users />
    }
  
];

export default AppRoutes;
