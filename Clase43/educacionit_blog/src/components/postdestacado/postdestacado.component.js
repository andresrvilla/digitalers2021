export default function PostDestacado({titulo, resumen, id}){
    return <div class="col">
    <div class="card">
      <div class="card-body">
        <h5 class="card-title">{ titulo }</h5>
        <p class="card-text">{ resumen }</p>
      </div>
    </div>
  </div>;
}