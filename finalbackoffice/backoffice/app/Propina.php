<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Curso;

class Propina extends Model
{
	protected $table = "propinas";
	protected $primaryKey = "id";
	protected $fillable = array("ano", "mes", "valor", "pago");
	public $timestamps = true;
	
	public function cursos()
	{
		return $this->belongsToMany('App\Curso', 'curso_propina')->withTimestamps();
	}
}
