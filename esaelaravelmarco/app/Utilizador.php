<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Curso;

class Utilizador extends Model
{
	
	protected $table = "utilizadores";
		protected $primaryKey = "id";
		protected $fillable = array("numero", "nome");
		public $timestamps = true;
		
		public function cursos(){
		return $this->belongsToMany('App\Curso', 'curso_utilizador')->withTimestamps();
	}
}
