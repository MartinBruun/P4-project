﻿namespace OG.AstVisiting
{
    public interface ICoordinateXyVisitable
    {
        public void Accept(ICoodinateXyVisitor visitor);
    }
}