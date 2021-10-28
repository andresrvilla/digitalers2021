import PostDestacado from "../postdestacado/postdestacado.component";

export default function PostPrincipales({ posts }) {
    return <><div class="row row-cols-1 row-cols-md-2 g-4">
        {posts
            .slice(0, 10)
            .map(p => <PostDestacado titulo={p.title} resumen={p.body.substring(0, 20)} id={p.id} />)}
    </div></>
}