<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Curso;

class Utilizador1 extends Model
{
	
	protected $table = "utilizadores";
		protected $primaryKey = "id";
		protected $fillable = array("numero", "nome");
		public $timestamps = true;
		
		public function cursos(){
		return $this->belongsToMany('App\Curso1', 'curso_utilizador')->withTimestamps();
	}
}
