import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List, Button } from 'semantic-ui-react';

function App() {

    const [operationTypes, setOperationTypes] = useState([]);
    useEffect(() => {
        axios.get('http://localhost:5000/api/operationTypes')
            .then(response => {
                console.log(response)
                setOperationTypes(response.data);
            })
    }, [])

    return (
        <div>
            <Header as='h2' icon='users' content='SaveYourMoney' />
            {/*<img src={logo} className="App-logo" alt="logo" />*/}
            <List>                   {operationTypes.map((operationType: any) => (
                    <li key={operationType.id}>
                        {operationType.title}
                    </li>))}
            </List>
            <Button>test</Button>
        </div>
    );
}

export default App;