import Header from "../header/header.component";
import Titulo from "../titulo/titulo.component";
import PostPrincipales from "../postsprincipales/postprincipales.component";
import { Route, Switch } from "react-router";
import AcercaDe from "../acercade/acercade.component";

//export default function(props){
//    const posts = props.posts;
export default function Blog({ posts }) {

    return <>
        <Header />
        <div className="container">
            <Titulo />
            <Switch>
                <Route exact path="/" render={ () => <PostPrincipales posts={posts} />} />
                <Route path="/acercade" component={AcercaDe} />
            </Switch>
            
        </div>
    </>;
}