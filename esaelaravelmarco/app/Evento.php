<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Curso;
use App\Disciplina;

class Evento extends Model
{
	protected $table = "eventos";
	protected $primaryKey = "id";
	protected $fillable = array("nome", "tipo","local");
	public $timestamps = true;
	
	public function cursos()
	{
		return $this->belongsToMany('App\Curso', 'curso_evento')->withTimestamps();
	}
	
	public function disciplinas()
	{
		return $this->belongsToMany('App\Disciplinas', 'disciplina_evento')->withTimestamps();
	}
	
}
