using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace gtscoliar.Database
{
    public partial class gtstg : DbContext
    {
        public gtstg()
            : base("name=gtstg")
        {
        }

        public virtual DbSet<anne_scoliar> anne_scoliar { get; set; }
        public virtual DbSet<evaluer> evaluers { get; set; }
        public virtual DbSet<mode_de_formation> mode_de_formations { get; set; }
        public virtual DbSet<module> modules { get; set; }
        public virtual DbSet<option> options { get; set; }
        public virtual DbSet<promo> promoes { get; set; }
        public virtual DbSet<section> sections { get; set; }
        public virtual DbSet<semasetre> semasetres { get; set; }
        public virtual DbSet<Specialité> Specialité { get; set; }
        public virtual DbSet<stg> stgs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<anne_scoliar>()
                .Property(e => e.session_scoliar)
                .IsUnicode(false);

            modelBuilder.Entity<evaluer>()
                .Property(e => e.stagiair)
                .IsUnicode(false);

            modelBuilder.Entity<evaluer>()
                .Property(e => e.semastre)
                .IsUnicode(false);

            modelBuilder.Entity<mode_de_formation>()
                .Property(e => e.codemodef)
                .IsUnicode(false);

            modelBuilder.Entity<mode_de_formation>()
                .Property(e => e.mode_formation)
                .IsUnicode(false);

            modelBuilder.Entity<module>()
                .Property(e => e.module1)
                .IsUnicode(false);

            modelBuilder.Entity<option>()
                .Property(e => e.codeopstion)
                .IsUnicode(false);

            modelBuilder.Entity<option>()
                .Property(e => e.options)
                .IsUnicode(false);

            modelBuilder.Entity<option>()
                .Property(e => e.specialite)
                .IsUnicode(false);

            modelBuilder.Entity<promo>()
                .Property(e => e.Diplome)
                .IsUnicode(false);

            modelBuilder.Entity<promo>()
                .Property(e => e.opption)
                .IsUnicode(false);

            modelBuilder.Entity<promo>()
                .Property(e => e.modeformation)
                .IsUnicode(false);

            modelBuilder.Entity<section>()
                .Property(e => e.nomsection)
                .IsUnicode(false);

            modelBuilder.Entity<section>()
                .Property(e => e.modeformation)
                .IsUnicode(false);

            modelBuilder.Entity<section>()
                .Property(e => e.options)
                .IsUnicode(false);

            modelBuilder.Entity<semasetre>()
                .Property(e => e.somestre)
                .IsUnicode(false);

            modelBuilder.Entity<Specialité>()
                .Property(e => e.codesp)
                .IsUnicode(false);

            modelBuilder.Entity<Specialité>()
                .Property(e => e.Specialite)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.numstg)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.adersse)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.commune)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.niveau_scolaire)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.prenom_pere)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.nom_mere)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.prenom_mere)
                .IsUnicode(false);

            modelBuilder.Entity<stg>()
                .Property(e => e.nasionalite)
                .IsUnicode(false);
        }
    }
}
