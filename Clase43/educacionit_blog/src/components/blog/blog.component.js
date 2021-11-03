import Header from "../header/header.component";
import Titulo from "../titulo/titulo.component";
import PostPrincipales from "../postsprincipales/postprincipales.component";
import { Route, Switch } from "react-router";
import AcercaDe from "../acercade/acercade.component";
import { useState } from 'react';

//export default function(props){
//    const posts = props.posts;
export default function Blog({ posts, store, incrementar, decrementar }) {

    const [contador, setContador] = useState(store.getState().contador)

    store.subscribe(() => {
        setContador(store.getState().contador);
    })

    return <>
        <Header />
        <div className="container">
            <Titulo />
            <Switch>
                <Route exact path="/" render={() => <PostPrincipales posts={posts} />} />
                <Route path="/acercade" component={AcercaDe} />
            </Switch>
            Contador {contador}<br />
            <button onClick={incrementar} >Incrementar</button><br />
            <button onClick={decrementar}>Decrementar</button><br />
        </div>
    </>;
}