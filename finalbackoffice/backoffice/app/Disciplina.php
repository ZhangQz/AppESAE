<?php

namespace App;
use App\Curso;
use App\Evento;

use Illuminate\Database\Eloquent\Model;

class Disciplina extends Model
{
	protected $table = "disciplinas";
	protected $primaryKey = "id";
	protected $fillable = array("nome");
	public $timestamps = true;
	
	public function cursos()
	{
		return $this->belongsToMany('App\Curso', 'curso_disciplina')->withTimestamps();
	}
	
	public function eventos()
	{
		return $this->belongsToMany('App\Evento', 'disciplina_evento')->withTimestamps();
	}
}
